# 📱 AR Business Card Using Unity

An **Augmented Reality (AR) Business Card** application developed using **Unity and Vuforia Engine**. The application recognizes a physical business card through the smartphone camera and overlays interactive digital content in real time.

Instead of a traditional static business card, this project transforms the card into an **interactive AR experience** where users can explore products, view information, interact with 3D models, and access contact options.

---

## ✨ Features

* 🔍 **Image Target Recognition**

  * Detects the business card using Vuforia Engine.
  * Displays AR content when the target is recognized.

* 🧊 **Interactive 3D Product Models**

  * Displays multiple products as 3D models.
  * Users can select and explore different products.

* 👆 **Touch-Based 3D Interaction**

  * Move 3D models using finger gestures.
  * Zoom in and out using touch gestures.
  * Explore products from different angles.

* 📋 **Product Information**

  * Displays product specifications and details.
  * Provides product-specific information through an interactive UI.

* 🌐 **Website Integration**

  * Opens the business website directly from the AR interface.

* 📧 **Email Integration**

  * Allows users to contact the business through email.

* 📞 **Contact Integration**

  * Provides direct contact functionality from the AR interface.

* 📱 **Mobile AR Experience**

  * Designed for smartphone-based augmented reality.
  * Combines physical and digital business information.

---

## 🛠️ Technologies Used

| Technology     | Purpose                           |
| -------------- | --------------------------------- |
| Unity          | AR application development        |
| Vuforia Engine | Image recognition and AR tracking |
| C#             | Application scripting             |
| TextMesh Pro   | User interface and text           |
| Git            | Version control                   |
| GitHub         | Source code hosting               |
| Git LFS        | Large asset management            |

---

## 🎯 How It Works

```text
Physical Business Card
          ↓
   Smartphone Camera
          ↓
   Vuforia Image Target
          ↓
    Target Recognition
          ↓
    AR Content Appears
          ↓
 ┌─────────────────────┐
 │  3D Product Models  │
 │  Product Details    │
 │  Website            │
 │  Email              │
 │  Contact            │
 └─────────────────────┘
```

---

## 📂 Project Structure

```text
ARBusinessCard/
│
├── Assets/
│   ├── Editor/
│   ├── Models/
│   ├── Products/
│   ├── Resources/
│   ├── Scenes/
│   ├── Scripts/
│   ├── StreamingAssets/
│   └── TextMesh Pro/
│
├── Packages/
│   ├── manifest.json
│   ├── packages-lock.json
│   └── com.ptc.vuforia.engine-11.4.4.tgz
│
├── ProjectSettings/
│
├── QCAR/
│
├── .gitignore
├── .gitattributes
└── README.md
```

---

## 🎮 3D Products

The application includes interactive 3D product models such as:

* 💻 Laptop
* 📱 Smartphone
* 🎧 Headphones
* 🔊 Speaker

Each product can be selected and explored through the AR interface.

---

## 👆 Touch Interaction

The application supports mobile touch interaction for AR models.

### Move

Touch and drag the model to reposition or rotate it.

### Zoom

Use a two-finger pinch gesture to zoom in and out.

### Explore

Interact with the model to view it from different angles.

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/kavink-io/ARBusinessCard.git
```

```bash
cd ARBusinessCard
```

### 2. Open in Unity

Open the project using the Unity version configured for this project.

Recommended:

```text
Unity 6000.5.10f1
```

### 3. Install / Load Vuforia

The project uses:

```text
Vuforia Engine 11.4.4
```

The Vuforia package is managed using **Git LFS**.

Make sure Git LFS is installed before cloning/downloading the repository.

```bash
git lfs install
```

Then:

```bash
git lfs pull
```

### 4. Open the Scene

Open:

```text
Assets/Scenes/SampleScene.unity
```

### 5. Configure the AR Target

The project contains the Vuforia image target database:

```text
Assets/StreamingAssets/Vuforia/
```

The AR business card image is used as the image target.

### 6. Build and Run

Connect an Android device, configure the required Android build settings, and build the application from Unity.

---

## 📸 AR Experience

The basic workflow is:

1. Launch the application.
2. Point the smartphone camera at the business card.
3. Allow Vuforia to recognize the image target.
4. AR content appears on the business card.
5. Select a product.
6. View the 3D model.
7. Move and zoom the model using touch gestures.
8. View product information.
9. Use the website, email, or contact buttons.

---

## 🧩 Main Scripts

The project contains several C# scripts responsible for the AR interaction and user interface.

```text
Assets/Scripts/
│
├── ARModelInteraction.cs
├── ARUIController.cs
├── ContactController.cs
├── ProductCatalogue.cs
├── ProductDetailsController.cs
├── ProductInfoController.cs
└── ProductUI.cs
```

### ARModelInteraction

Handles interaction with the AR 3D models, including touch-based manipulation.

### ARUIController

Controls the AR user interface and associated interactions.

### ContactController

Handles contact-related actions such as website, email, and phone interactions.

### ProductCatalogue

Manages the available products.

### ProductDetailsController

Controls product-specific information and details.

### ProductInfoController

Handles product information displayed in the AR interface.

### ProductUI

Manages product-related UI interactions.

---

## 💡 Use Case

This project can be used by businesses to transform conventional business cards into interactive digital experiences.

Potential applications include:

* 🏢 Business promotion
* 🛍️ Product showcasing
* 📱 Digital marketing
* 💼 Corporate business cards
* 🎨 Interactive portfolios
* 🏪 Product demonstrations
* 🚀 Startup presentations

---

## 🔮 Future Enhancements

Possible future improvements include:

* [ ] Multiple business card targets
* [ ] More 3D products
* [ ] Product animations
* [ ] Product search
* [ ] Online product catalogue
* [ ] Cloud-based product updates
* [ ] Analytics for user interactions
* [ ] AR product comparison
* [ ] Android APK release
* [ ] iOS support

---

## 📌 Requirements

### Software

* Unity 6000.5.10f1
* Vuforia Engine 11.4.4
* Git
* Git LFS
* Android SDK/NDK for Android builds

### Hardware

* Android smartphone with camera
* Physical AR business card / image target

---

## 📦 Git LFS

This project uses **Git Large File Storage (Git LFS)** for large project assets.

Initialize Git LFS:

```bash
git lfs install
```

Download LFS assets:

```bash
git lfs pull
```

Check tracked LFS files:

```bash
git lfs ls-files
```

---

## 👨‍💻 Developer

**Kavin K**

B.Tech Information Technology
Sathyabama Institute of Science and Technology
Chennai, Tamil Nadu, India

---

## 📄 License

This project is developed for **educational, academic, and demonstration purposes**.

---

## ⭐ Project

If you find this project useful or interesting, consider giving the repository a ⭐ on GitHub.

**Repository:**
https://github.com/kavink-io/ARBusinessCard
