using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class ExtendedEditorWindow : EditorWindow
{
	public Dictionary<EventType, Action> EventMap { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="ExtendedEditorWindow"/> class.
	/// </summary>
	protected ExtendedEditorWindow()
	{
		this.EventMap = new Dictionary<EventType, Action>
		{
			{ EventType.ContextClick, this.OnContext },
			{ EventType.Layout, this.OnLayout },
			{ EventType.Repaint, this.OnRepaint },

			{ EventType.KeyDown, () => {
				this.OnKeyDown(new Keyboard(Event.current));
			}},

			{ EventType.KeyUp, () => {
				this.OnKeyUp(new Keyboard(Event.current));
			}},

			{ EventType.MouseDown, () => {
				this.OnMouseDown((MouseButton)Event.current.button, Event.current.mousePosition);
			}},

			{ EventType.MouseDrag, () => {
				this.OnMouseDrag((MouseButton)Event.current.button, Event.current.mousePosition, Event.current.delta);
			}},

			{ EventType.MouseMove, () => {
				this.OnMouseMove(Event.current.mousePosition, Event.current.delta);
			}},

			{ EventType.ScrollWheel, () => {
				this.OnScrollWheel(Event.current.delta);
			}}
		};
	}

	protected virtual void OnGUI()
	{
		var controlId =
			GUIUtility.GetControlID(FocusType.Passive);

		var controlEvent =
			Event.current.GetTypeForControl(controlId);

		if(this.EventMap.ContainsKey(controlEvent))
		{
			this.EventMap[controlEvent].Invoke();
		}
	}

	protected void OnKeyDown(Keyboard keyboard)
	{
	}

	protected void OnKeyUp(Keyboard keyboard)
	{
	}

	protected virtual void OnMouseDown(MouseButton button, Vector2 position)
	{
	}

	protected virtual void OnMouseDrag(MouseButton button, Vector2 position, Vector2 delta)
	{
	}

	protected virtual void OnMouseMove(Vector2 position, Vector2 delta)
	{
	}
	
	protected virtual void OnContext()
	{
	}

	protected virtual void OnLayout()
	{
	}

	protected virtual void OnRepaint()
	{
	}

	protected virtual void OnScrollWheel(Vector2 delta)
	{
	}
}