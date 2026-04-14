<p align="center">✨Dvurechensky✨</p>

<h1 align="center"> Infocard File Processor for 💤 Freelancer Rebirth 💤 </h1>

<div align="center" style="margin: 20px 0; padding: 10px; background: #1c1917; border-radius: 10px;">
  <strong>🌐 Language: </strong>
  
  <a href="./README.ru.md" style="color: #F5F752; margin: 0 10px;">
    🇷🇺 Russian
  </a>
  | 
  <span style="color: #0891b2; margin: 0 10px;">
    ✅ 🇺🇸 English (current)
  </span>
</div>

---

> [!NOTE]
> This project is part of the **Lizerium** ecosystem and belongs to the following direction:
>
> - [`Lizerium.Tools.Structs`](https://github.com/Lizerium/Lizerium.Tools.Structs)
>
> If you are looking for related engineering and supporting tools, start there.

# ✨ Table of Contents

- [✨ Table of Contents](#-table-of-contents)
  - [What does it do❓](#what-does-it-do)
    - [💥 Core 💥](#-core-)
    - [🌟 Extracting files from `dll` using `Resource Hacker` 🌟](#-extracting-files-from-dll-using-resource-hacker-)
    - [😈 Command Shell 😈](#-command-shell-)

---

## What does it do❓

### 💥 Core 💥

- Generates a **`FLResources`** export targeting `.NET 3.5`, compatible with `Unity`

  ![alt text](Media/dlls.png)

- Main access class when integrating the library into a project: `ResControl`

  It provides the following API:
  - `Dictionary<string, int> LoadIds(int ids)`  
    → Input: numeric value from INI (`ids_name` or `ids_info`)  
    → Output: DLL file name + string index

  - `StatusHandle GetData(string nameResources, int id)`  
    → Input: RESX resource name embedded in DLL  
    (`OfferBribeResources_name, NameResources_name, EquipResources_name, SBM3_name, SBM2_name, SBM_name, SBM_info, EquipResources_info, MiscTextInfo2_info, InfoCards_info, MiscText_info, SBM3_info`)  
    → Output: resource value by key from initialized RESX

---

- `FLGenerateLibrary` generates `.resx` files for `FLResources` using data extracted from Win32 `.dll` files of `Freelancer (2003)`

  Data is предварительно extracted using [`Resource Hacker`](Soft/reshacker_setup.exe).  
  Extraction steps are described below.

---

- `FLEDId` — a utility for quick conversion between `ids_name` / `ids_info` and the numeric values stored inside resource DLLs
  - Works independently of `freelancer.ini` structure
  - Can also resolve INI ID from DLL name + numeric identifier

---

### 🌟 Extracting files from `dll` using [`Resource Hacker`](Soft/reshacker_setup.exe) 🌟

1. Open a `.dll` in [`Resource Hacker`](Soft/reshacker_setup.exe), e.g. `equipresources.dll`
   - Select `String Table`
   - Save `.rc` file into the `INPUT` folder (located near the `.exe`)
   - Rename `.rc` → `data.txt`
   - Remove line:
     ```
     LANGUAGE LANG_NEUTRAL, SUBLANG_NEUTRAL
     ```

   ![alt text](Media/res1.png)  
   ![alt text](Media/image.png)  
   ![alt text](Media/image-1.png)  
   ![alt text](Media/image-2.png)

   > [!NOTE]
   > You have now created a file for resolving `ids_name` fields.

---

2. If the DLL contains an `HTML` section:
   - Select `HTML`
   - Save `.rc` into `INPUT\HTML`
   - Delete the `.rc` file (we only need the generated `.txt` files for each `.html`)

   ![alt text](Media/image-3.png)  
   ![alt text](Media/image-4.png)  
   ![alt text](Media/image-5.png)

   > [!NOTE]
   > You have now created files for resolving `ids_info` fields.

---

3. Final structure should look like:

![alt text](Media/image-6.png)

---

### 😈 Command Shell 😈

1. Command `g [filename.ini] [field]`  
   → Finds unique values of a field inside an INI file located in the `Analis` folder
   - `[filename.ini]` — must exist in `Analis`
   - `[field]` — field name to analyze

   Example:

   ```sh
   g example.ini progres_field
   ```

---

2. Command `c [path/to/file.resx]` or `clear [path/to/file.resx]`
   → Clears all resources inside a `.resx` file

   Example:

   ```sh
   c path/to/file.resx
   ```

---

3. Command `st [path/to/file.resx] [path/to/data.txt]`
   → Generates `.resx` entries from TXT data

   Example:

   ```sh
   st path/to/file.resx path/to/data.txt
   ```

---

4. Command `st [path/to/file.resx] [path/to/html]`
   → Generates `.resx` entries from HTML TXT files

   Example:

   ```sh
   st path/to/file.resx path/to/html
   ```

---

5. Command `import` or `i`
   → Copies test data into `INPUT` folder

   Example:

   ```sh
   import
   ```

---

6. Command `all` or `a`
   → Generates resource files from `INPUT` into `OUTPUT`

   Example:

   ```sh
   all
   ```

---

7. Command `rhtml`
   → Outputs processed HTML text formatted for `Unity TextMeshPro`

---

8. Command `exit` / `e` / `q`
   → Exit application

---

9. Command starting with `::text`
   → Searches for matching text inside embedded data in `FLResources.dll`

---

10. Command starting with `::489`
    → Searches for matching identifiers inside embedded data

---

<p align="center">✨Dvurechensky✨</p>
