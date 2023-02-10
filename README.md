---
title: Unity Mod Templates
description: A collection of Project and Item templates to speed up the process of creating Unity game mods using the BepInEx patcher and plugin framework.
---

# Unity Mod Templates

A collection of Project and Item templates to speed up the process of creating Unity game mods using the BepInEx patcher and plugin framework.

## Overview

The template pack comes with the following:

### Unity Mod Project Template

The project template contains a suggested folder structure, references and starter classes for a new BepInEx based Unity mod.

![](.\media\newprojectemplate.png)

![](.\media\projecttemplate.png)

### Item Templates

Four item templates are included that provide boiler plate code for a number of core mod class types.

![](G:\My Drive\Documents\Daft Apple Games\Subnautica Mods\Visual Studio Mod Templates\media\newitemtemplates.png)

#### BepInEx Plugin Class Item Template

This contains a suggested structure for a "plugin" class for use with the BepInEx framework.

![](.\media\pluginclasstemplate.png)

#### MonoBehaviour Class Item Template

This contains a suggested structure for a "monobehaviour" class, for introducing new components and behaviours.

![](.\media\monobehaviourclasstemplate.png)

#### Static Utils Class Item Template

This contains a suggested structure for a static "utils" class, for creating static helper methods.

![](.\media\utilsclasstemplate.png)

#### Harmony Patch Class Item Template 

This contains a suggested structure for a "patch" class, for building Harmony patch classes and methods.

![](.\media\patchclasstemplate.png)

## Installation

The template pack comes as a single ZIP file. Unzip this file to a location on your machine.

1. You should have a folder structure as follows:

   ![](.\media\templatefolderstructure.png)

2. In Windows Explorer, navigate to this location:

   ```Documents\Visual Studio 2022\```

3. Copy the unzipped Templates folder into the Visual Studio 2022 folder. This will add the appropriate ZIP files to the Visual Studio template folder.

4. Restart Visual Studio.

The templates should now be available for use.

## Refreshing the Templates

If you download and apply an update to the templates, you may have to run this process to make the updated templates available in Visual Studio:

1. From the Start menu, open Visual Studio 2022, right click Developer Command Prompt for VS2022 and select More > Run as administrator:

   ![](.\media\runcommandprompt.png)

2. Enter and execute the following command:

   ```
   devenv /installvstemplates
   devenv /updateconfiguration
   ```

3. Restart Visual Studio.

The updated templates should now be available for use.

## Building the Templates

All source is available in the Templates folder. To build and deploy changes to the templates, you can use the included batch files.

1. Amend ```config.bat``` and set the path to 7-zip and to the Visual Studio Documents folder.
2. Run ```build.bat``` to build a new release ZIP in the Releases folder.
3. Run ```build.bat Y``` to build and deploy to your local Visual Studio installation.

A ZIP file for release and deployment can be found in the Releases folder.