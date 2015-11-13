# Web View Demo

This demo shows how to use a hosted Website as a UWP app. You need to provide the URI of the website in the `package.manifest`. The one included will work temporarily but I'll shut down the website in the next two weeks. 

If you added the URI you can play around with the three levels of WinRT access, please ensure that the Rule for the website is `Include`.

## None

Same as if you're running it in the web browser. The page will be displayed all links related to the page will be shown in the UWP app. Any other links outside of the domain will open a web browser.

## Allowed for web only

The button `Show local toast notification` will work. It has access to the Windows Runtime Component added to the webview
The button `Change your lockscreen` will not work. It hasn't been granted access to the System.

## All

Both button will work. For the lockscreen, select a picture from the file picker and press `WinCMD + L` to see the result.
