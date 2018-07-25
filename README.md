### Measurement of the distance to the object with the help of the web-camera.

To run project you need to install libemgucv library (tested on `libemgucv-windows-x64-2.4.0.1717`).

After installing open file `MainWindow.cs`, `line 24` and provide path to  `.xml` file to recognize object.

Example:
    `"C:\\Emgu\\emgucv-windows-x64 2.4.0.1717\\opencv\\data\\haarcascades\\haarcascade_frontalface_default.xml"`
    
#### Notice: function on `line 90` contains params, which are individual to each camera. `1400` means pixels per cm; `f` means focus length.

To run properly, please use monotone background.
