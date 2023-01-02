## WLED Pixel Art Generator

This is an extremely basic and early version of a pixel art generator targeted for WS281x 16x16 LED matrix panels. This requires v0.14.0-b1 or higher (2D Matrix support). It has not been tested with 1D and very well won't work with that.  
  
The code is surely a bit messy and can probably be optimized in over a thousand different ways, read on to learn about contributing/helping out if you so choose. I work on this in my limited spare time so know that PRs, features, issues, etc may take a while. Tesing has been extremely limited and there are probably several cases where this does not meet your expectations. Please open issues if there is anything dire needing to be fixed or added.

**Important** This has only been tested with a single 16x16 matrix with the LED Panel Layout of 1st LED = Top Right, Orientation=Horizontal, and Serpentine=ENABLED. This also relies on your WLED being off before using the resulting JSON as it does not include an off command. This includes presets as well, make sure the LEDs are off before using a preset.

## Settings Available
1) Serpentine Mode - should be enabled to get the results for the LED matrix settings noted above.
2) Use Hex - This is currently *NOT* implemented, so it doesn't matter what the setting is, but when it is implemented, you will have the choice of using Hex (more efficient) or a sub-array of RGB values.
3) Include On/Bri elements - Check this to include the on:true and bri segments of the JSON array. If you select this, you will be able to set your brightness level before generating the JSON. (Default 25)

## How to use
1) Choose a 16x16 px image (**must** be 16x16 px for this to work else you will get an error.)
2) Select the settings you want as described above and click Generate.
3) Copy the output and use to make a post request to your WLED controller.
4) To repeat, click the reset button to start again and enable the file select button.  

### Advanced Features
1) After generating JSON, you will be presented with a few new options - Post to WLED, WLED Off, and Save as Preset.
2) Save As Preset - This feature is in very early beta, you absolutely MUST have presets (an actual json object) in `{WLED-IP}/edit` under `presets.json` in order for this to work. For best results, ensure that you have the 'Include On/Bri elements' enabled so that your preset API command will turn on your LEDs. This will add your newly generated pixel art JSON as a preset in your WLED. See 'Persistent Settings' for details, but your presets.json will be saved and your existing presets.json will be saved in a .BAK file. When you click this, you will be prompted to enter a Preset name. Click Save to add this preset to your WLED presets. If you want to manually backup your presets, you can click the 'Load WLED Presets' button and it will save it as a file called `presets_manual_backup.json`.
3) File Menu contains a settings section to save default settings going forward. This is where you can set your IP/URL to your WLED controller. Make sure this is set if you wish to use the Save as Preset, Post to WLED, or WLED Off features, otherwise it obviously won't be able to connect.
4) Post to WLED - you can immediately send your pixel art to your WLED to preview it. Note that your WLED will stay on with the pixel art until you click WLED Off.

## Persistent Settings
You can now save basic settings; such as your WLED IP/URL and the aforementioned settings. This save file is created in your Documents folder inside a folder called 'WLED_Pixel_Art_Generator'.  

The app will also save your presets from the WLED API and back them up if you save the current pixel art to your presets. These are stored in the same directory as the settings.

## Build/Run
Clone this repo and open in Visual Studio. Click the run button at the top or you can choose to build your own exe.

## Contributing
If you would like to contribute to this project, you are more than welcome to fork and/or create PRs with new features or to address issues.

## Upcoming Features
In addition to UX improvements and validation, keep an eye on the Issues page for upcoming features. Again, post an issue if there is something you'd like to see.

## Releases
Will be found under releases. They may be pre-release so they may not show up on this page. Go to the Releases page to find published releases.