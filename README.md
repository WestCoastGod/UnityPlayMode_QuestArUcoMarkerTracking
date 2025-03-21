# Quest ArUco Marker Tracking

This repository enables **single and multi-marker detection and tracking** using OpenCV with the **Meta Quest 3/3S Passthrough Camera API**.  
It provides a robust solution for **augmented reality applications** on Quest devices, supporting both **ArUco** and **ChArUco** markers.

For a demonstration, check out the following videos:

▶ **Single Marker Tracking Demo (ArUco)**  
[![Single Marker Demo](https://img.youtube.com/vi/cJSjYMuJu8w/0.jpg)](https://www.youtube.com/watch?v=cJSjYMuJu8w)

▶ **Multi-Marker Tracking Demo (ArUco)**  
[![Multi-Marker Demo](https://img.youtube.com/vi/Y0mqQ_nxve8/0.jpg)](https://www.youtube.com/watch?v=Y0mqQ_nxve8)

▶ **ChArUco Marker Tracking Demo**  
[![ChArUco Demo](https://img.youtube.com/vi/NnHkcNXevxs/0.jpg)](https://www.youtube.com/watch?v=NnHkcNXevxs)

## Dependencies

⚠ **Important Notice**  
When opening the project for the first time, you will likely encounter errors. This is because **OpenCV for Unity** is not yet installed.  
**Please ignore the errors initially, proceed to open the project, and install OpenCV for Unity manually.**  

This project uses **OpenCV for Unity**.  
Please purchase and install it from the Unity Asset Store:  
[OpenCV for Unity](https://assetstore.unity.com/packages/tools/integration/opencv-for-unity-21088?locale=en-US)  

Tested with **OpenCV for Unity v2.6.5**.

## Usage

### 🔖 Marker Preparation  
To use this project, please download and install the required marker files from the following links:

- **ArUco Markers**: [ArUcoMarker.pdf](https://github.com/TakashiYoshinaga/QuestArUcoMarkerTracking/blob/main/ArUcoMarker.pdf)  
- **ChArUco Marker**: [ChArUcoMarker.pdf](https://github.com/TakashiYoshinaga/QuestArUcoMarkerTracking/blob/main/ChArUcoMarker.pdf)  

### 🎮 Unity Scenes

- **ArUco Marker Tracking (Single & Multi)**: `ArUcoMarkerTracking.unity`  
- **ChArUco Marker Tracking**: `ChArUcoMarkerTracking.unity`  

### ⚙ Default Settings

#### ArUco Marker  
- Marker Dictionary: **DICT_4X4_50**  
- Marker Size: **0.1m**  
**If needed, feel free to modify these settings to fit your use case.**

#### ChArUco Marker  
- Marker Dictionary: **DICT_4X4_50**  
- Board Configuration: **5 x 4 squares**  
- Square Size: **0.05m**  
**These values are used as default in the ChArUco sample scene. Adjust as needed.**

### 🔄 View Mode Switching  
You can switch the view mode by pressing the **A button** on the controller.

## Reference Repositories

This implementation is based on the following sample repositories:  

- [Unity-PassthroughCameraApiSamples](https://github.com/oculus-samples/Unity-PassthroughCameraApiSamples)  
- [QuestCameraKit](https://github.com/xrdevrob/QuestCameraKit)  

## Contact

If you have any questions, feel free to reach out:  

- **X (Twitter)**:  
  - (EN) [@Tks_Yoshinaga](https://x.com/Tks_Yoshinaga)  
  - (JP) [@Taka_Yoshinaga](https://x.com/Taka_Yoshinaga)  
- **LinkedIn**: [Tks Yoshinaga](https://www.linkedin.com/in/tks-yoshinaga/)  
- **Discord**: [Join the community](https://discord.gg/kDENwuPD4t)  
