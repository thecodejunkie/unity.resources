using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Represents the keyboard device.
/// </summary>
public class Keyboard
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Keyboard"/> class.
	/// </summary>
	public Keyboard()
	{	
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Keyboard"/> class,
	/// from the provided event <paramref name="evt"/>.
	/// </summary>
	/// <param name="evt">An <see cref="Event"/> instance.</param>
	public Keyboard(Event evt)
	{
		this.Code = evt.keyCode;
		this.IsAlt = evt.alt;
		this.IsCapsLock = evt.capsLock;
		this.IsControl = evt.control;
		this.IsFunctionKey = evt.functionKey;
		this.IsNumeric = evt.numeric;
		this.IsShift = evt.shift;
		this.Modifiers = evt.modifiers;
	}

	public KeyCode Code { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether the alt key is pressed.
	/// </summary>
	/// <value><c>true</c> if the alt key is pressed; otherwise, <c>false</c>.</value>
	public bool IsAlt { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether the caps lock key is pressed.
	/// </summary>
	/// <value><c>true</c> if the caps lock key is pressed; otherwise, <c>false</c>.</value>
	public bool IsCapsLock { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether the control key is pressed.
	/// </summary>
	/// <value><c>true</c> if the control key is pressed; otherwise, <c>false</c>.</value>
	public bool IsControl { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether a function key is pressed.
	/// </summary>
	/// <value><c>true</c> if a function key is pressed; otherwise, <c>false</c>.</value>
	public bool IsFunctionKey { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether a numeric key is pressed.
	/// </summary>
	/// <value><c>true</c> if a numeric key is pressed; otherwise, <c>false</c>.</value>
	public bool IsNumeric { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether the control key is pressed.
	/// </summary>
	/// <value><c>true</c> if the control key is pressed; otherwise, <c>false</c>.</value>
	public bool IsShift { get; set; }

	/// <summary>
	/// Gets or sets the modifier keys that are pressed.
	/// </summary>
	/// <value>A combination of <see cref="EventModifiers"/> values.</value>
	public EventModifiers Modifiers { get; set; }
}
