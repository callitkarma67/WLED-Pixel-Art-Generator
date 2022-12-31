## WLED Pixel Art Generator

This is an extremely basic and early version of a pixel art generator targeted for WS281x 16x16 LED matrix panels. This requires v0.14.0-b1 or higher (2D Matrix support). It has not been tested with 1D and very well won't work with that.  
  
The code is surely a bit messy and can probably be optimized in over a thousand different ways, read on to learn about contributing/helping out if you so choose. I work on this in my limited spare time so know that PRs, features, issues, etc may take a while. Tesing has been extremely limited and there are probably several cases where this does not meet your expectations. Please open issues if there is anything dire needing to be fixed or added.

**Important** This has only been tested with a single 16x16 matrix with the LED Panel Layout of 1st LED = Top Right, Orientation=Horizontal, and Serpentine=ENABLED.

## Settings Available
1) Serpentine Mode - should be enabled to get the results for the LED matrix settings noted above.
2) Use Hex - This is currently *NOT* implemented, so it doesn't matter what the setting is, but when it is implemented, you will have the choice of using Hex (more efficient) or a sub-array of RGB values.
3) Include On/Bri elements - Check this to include the on:true and bri segments of the JSON array. If you select this, you will be able to set your brightness level before generating the JSON. (Default 25)

## How to use
1) Choose a 16x16 px image (**must** be 16x16 px for this to work else you will get an error.)
2) Select the settings you want as described above and click Generate.
3) Copy the output and use to make a post request to your WLED controller.
4) To repeat, click the reset button to start again and enable the file select button.

## Build/Run
Clone this repo and open in Visual Studio. Click the run button at the top or you can choose to build your own exe.

## Contributing
If you would like to contribute to this project, you are more than welcome to fork and/or create PRs with new features or to address issues.

## Releases
I may or may not add releases here as exe and source code zips. 