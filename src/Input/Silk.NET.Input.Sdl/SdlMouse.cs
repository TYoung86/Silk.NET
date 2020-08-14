using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Input.Internals;
using Silk.NET.SDL;

namespace Silk.NET.Input.Sdl
{
    internal class SdlMouse : MouseImplementationBase, ISdlDevice
    {
        private readonly SdlInputContext _ctx;
        private readonly List<MouseButton> _downButtons = new List<MouseButton>();
        private bool _wheelChanged;

        /// <summary>
        /// Used by SdlCursor.
        /// </summary>
        internal bool IsRaw { get; set; }

        /// <summary>
        /// The current raw mouse position. This is done because when SDL is in raw mouse mode, it doesn't allow
        /// unlimited mouse movement like GLFW does so we have to simulate it.
        /// </summary>
        internal Vector2 AggregatePoint { get; set; }

        public SdlMouse(SdlInputContext ctx)
        {
            _ctx = ctx;
            Cursor = new SdlCursor(this, ctx);
        }

        public override string Name { get; } = "Silk.NET Mouse (via SDL)";
        public override int Index { get; } = 0;
        public override bool IsConnected { get; } = true;

        public override IReadOnlyList<MouseButton> SupportedButtons { get; } = new[]
            {MouseButton.Left, MouseButton.Middle, MouseButton.Right, MouseButton.Button4, MouseButton.Button5};

        public override IReadOnlyList<ScrollWheel> ScrollWheels { get; } = new ScrollWheel[1];

        public override unsafe PointF Position
        {
            get
            {
                int x, y;
                _ctx.Sdl.GetMouseState(&x, &y);
                return new PointF(x, y);
            }
            set => _ctx.Sdl.WarpMouseInWindow((Window*) _ctx.Handle, (int) value.X, (int) value.Y);
        }

        public override ICursor Cursor { get; }
        public override bool IsButtonPressed(MouseButton btn) => _downButtons.Contains(btn);
        public override event Action<IMouse, PointF>? MouseMove;
        public override event Action<IMouse, ScrollWheel>? Scroll;

        public void Update()
        {
            if (!_wheelChanged && Unsafe.As<ScrollWheel, Vector2>(ref ((ScrollWheel[]) ScrollWheels)[0]) != default)
            {
                ((ScrollWheel[]) ScrollWheels)[0] = default;
            }
        }

        public void DoEvent(Event @event)
        {
            switch ((EventType) @event.Type)
            {
                case EventType.Mousemotion:
                {
                    if (IsRaw)
                    {
                        var aggr = AggregatePoint += new Vector2(@event.Motion.Xrel, @event.Motion.Yrel);
                        MouseMove?.Invoke(this, Unsafe.As<Vector2, PointF>(ref aggr));
                    }
                    else
                    {
                        MouseMove?.Invoke(this, new PointF(@event.Motion.X, @event.Motion.Y));
                    }

                    break;
                }
                case EventType.Mousebuttondown:
                {
                    _downButtons.Add(MapButton(@event.Button.Button));
                    HandleMouseDown(this, MapButton(@event.Button.Button));
                    break;
                }
                case EventType.Mousebuttonup:
                {
                    _downButtons.Remove(MapButton(@event.Button.Button));
                    HandleMouseUp(this, MapButton(@event.Button.Button));
                    break;
                }
                case EventType.Mousewheel:
                {
                    _wheelChanged = true;
                    Scroll?.Invoke
                        (this, ((ScrollWheel[]) ScrollWheels)[0] = new ScrollWheel(@event.Wheel.X, @event.Wheel.Y));
                    break;
                }
            }
        }

        private static MouseButton MapButton(byte btn) => btn switch
        {
            1 => MouseButton.Left,
            2 => MouseButton.Middle,
            3 => MouseButton.Right,
            _ => (MouseButton) (btn - 1)
        };
    }
}
