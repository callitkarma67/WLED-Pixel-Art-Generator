## WLED Pixel Art Generator

This is an extremely basic and early version of a pixel art generator targeted for WS281x 16x16 LED matrix panels. This requires v0.14.0-b1 or higher (2D Matrix support). It has not been tested with 1D and very well won't work with that.  
  
The code is surely a bit messy and can probably be optimized in over a thousand different ways, read on to learn about contributing/helping out if you so choose. I work on this in my limited spare time so know that PRs, features, issues, etc may take a while. Tesing has been extremely limited and there are probably several cases where this does not meet your expectations. Please open issues if there is anything dire needing to be fixed or added.

**Important** This has only been tested with a single 16x16 matrix with the LED Panel Layout of 1st LED = Top Right, Orientation=Horizontal, and Serpentine=ENABLED. This also relies on your WLED being off before using the resulting JSON as it does not include an off command. This includes presets as well, make sure the LEDs are off before using a preset.  

Use at your own risk, the author and contributers of this application are not responsible for any damage caused as a result of the use of this software. Make sure you have the proper safety precautions and power requirements for your LEDs. This application does not take into account the power or brightness limitations of your setup and just restricts it to the WLED restriction range of 0-255 for brightness. The default brightness level is set to 25 which may or may not be suitable for your setup, please test your setup before using this application. This software comes with no warranty whatsoever.

## Settings Available
1) Serpentine Mode - should be enabled to get the results for the LED matrix settings noted above.
2) Use Hex - This is currently *NOT* implemented, so it doesn't matter what the setting is, but when it is implemented, you will have the choice of using Hex (more efficient) or a sub-array of RGB values.
3) Include On/Bri elements - Check this to include the on:true and bri segments of the JSON array. If you select this, you will be able to set your brightness level before generating the JSON. (Default 25; Range 0-255)

## How to use
For best results, name your files without spaces and in camelcase. e.g. `myFile.png`
1) Choose a 16x16 px image (**must** be 16x16 px for this to work else you will get an error.)
2) Select the settings you want as described above and click Generate.
3) Copy the output and use to make a post request to your WLED controller. There are copy buttons above each output box to directly copy the contents to your clipboard.
4) To repeat, click the reset button, or 'Options/Reset All' to start again and enable the file select button.  

### Advanced Features
1) After generating JSON, you will be presented with a few new options - Post to WLED, WLED Off, and Save as Preset.
2) Save As Preset - This feature is in very early beta, you absolutely MUST have presets (an actual json object) in `{WLED-IP}/edit` under `presets.json` in order for this to work. For best results, ensure that you have the 'Include On/Bri elements' enabled so that your preset API command will turn on your LEDs. This will add your newly generated pixel art JSON as a preset in your WLED. See 'Persistent Settings' for details, but your presets.json will be saved and your existing presets.json will be saved in a .BAK file. When you click this, you will be prompted to enter a Preset name. Click Save to add this preset to your WLED presets. If you want to manually backup your presets, you can click the 'Load WLED Presets' button and it will save it as a file called `presets_manual_backup.json`.
3) File Menu contains a settings section to save default settings going forward. This is where you can set your IP/URL to your WLED controller. Make sure this is set if you wish to use the Save as Preset, Post to WLED, or WLED Off features, otherwise it obviously won't be able to connect.
4) Post to WLED - you can immediately send your pixel art to your WLED to preview it. Note that your WLED will stay on with the pixel art until you click WLED Off.
5) Options Menu - **[Reset All]** will clear all fields within the application, but will NOT delete your save data. **[Enable Python Mode]** will create a new tab for Python generation. This tab will allow you to bulk import image files which in turn will populate the box on this tab with python variables with values of the JSON to be posted for each specific image. Just like the main tab, this requires 16x16px images. It takes the file names of the image files and uses them as the variable names so name accordingly. For example, if you upload 2 images called `sprite1.png` and `sprite2.png`, the output will be two valid python dictionary variables as below. The output is based on your settings for on/bright inclusion. This also will automatically convert the lower case true into True as Python requires. **Note** that the box length may max out, I was able to upload 62 images at once and I had no issues with losing text/getting truncated. Note that Python generation may take time, and the application will be unresponsive during processing. A progress bar will show for the duration of processing.
```python
sprite1 = {"on":True,"bri":100....} #etc...
sprite2 = {"on":True,"bri":100....} #etc...
```
6) Python List/Dictionary Generation - allows for generation of Python List/Dictionary object generation. Having these allows you to do things like iterating through your pixel art, randomizing it (shuffling the list using python's `random.shuffle()` method as it is limited to lists). Example usage as below, using above examples `sprite1.png` and `sprite2.png`.
```python
# List of strings (file/JSON variable names to get via indexing)
artList = [
    'sprite1',
    'sprite2',
    ...
]

# Dictionary pairing above list strings to above JSON variables containing the post data
artDict = {
    'sprite1': sprite1,
    'sprite2': sprite2,
    ...
}

# Basic usage example, you can easily shuffle and iterate through the artList for variety
# include time.sleep(n) to display art for n seconds before powering off/moving to the next image.
postJson = artDict.get(artList[0])
resp = requests.post("http://[WLED-IP]/json/state", json=postJson)
off = requests.post("http://[WLED-IP]/json/state", json={"on": False})
```

7) Home Assistant Mode [Settings/Enable Home Assistant] will enable Home Assistant Switch generation to be used in your Home Assistant `configuration.yaml`. From the main tab, it will auto generate the YAML required on the Home Assistant tab, note that the tab will not appear until the 'Generate' button is clicked. Alternatively, you can bulk generate Home Assistant switch yaml from the 'Python/Gen' tab. Check the box 'Generate for Home Assistant Switches' under the select file button for Home Assistant bulk yaml to be generated. Note that while this is checked, Python generation will _not_ occur.  
** Also important to note, the identifiers and Friendly Name elements will be populated using the filename of each image uploaded to this tool. The tool will automatically lower case the filename before inserting into the identifier to comply with home assistant rules, but will not remove spaces. Make sure your filenames do not have spaces. Basic example usage below, see [Home Assistant docs](https://www.home-assistant.io/docs/) for more details.
```yaml
# configuration.yaml
...
...
switch: !include switches.yaml
```
```yaml
# switches.yaml
{Paste the output from the Home Assistant tab of this tool here.}
```

## Persistent Settings
You can now save basic settings; such as your WLED IP/URL and the aforementioned settings, this also includes your selection of using Python Mode. This save file is created in your Documents folder inside a folder called 'WLED_Pixel_Art_Generator'.  

The app will also save your presets from the WLED API and back them up if you save the current pixel art to your presets. These are stored in the same directory as the settings.

## Build/Run
Clone this repo and open in Visual Studio. Click the run button at the top or you can choose to build your own exe.

## Contributing
If you would like to contribute to this project, you are more than welcome to. See the Contributing.md file to learn more.

## Upcoming Features
In addition to UX improvements and validation, keep an eye on the Issues page for upcoming features. Again, post an issue if there is something you'd like to see.

## Releases
Will be published and can found under releases.