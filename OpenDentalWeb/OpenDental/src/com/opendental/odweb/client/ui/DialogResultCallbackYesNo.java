package com.opendental.odweb.client.ui;

/** GWT is completely asynchronous so we have to use callbacks in order to have the windows return results. */
public interface DialogResultCallbackYesNo {
	void Yes();
	void No();
}