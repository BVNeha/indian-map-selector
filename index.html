<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <title>Location Selector</title>
  <link rel="stylesheet" href="style.css">
  <!-- Font Awesome for icons -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css">
  <!-- Optional: Noto Sans Devanagari font for Hindi text -->
  <link href="https://fonts.googleapis.com/css2?family=Noto+Sans+Devanagari&display=swap" rel="stylesheet">
  <style>
    /* General body and form layout */
    body {
      font-family: Arial, sans-serif;
      padding: 20px;
      margin: 0;
      background-color: #f4f4f4;
    }

    /* Form section */
    h1 {
      margin-top: 30px;
    }

    label {
      display: block;
      margin-top: 10px;
      font-weight: bold;
    }

    select, button {
      width: 100%;
      max-width: 300px;
      padding: 8px;
      margin-top: 5px;
      margin-bottom: 15px;
      border: 1px solid #ccc;
      border-radius: 4px;
    }

    button {
      background-color: #007BFF;
      color: white;
      cursor: pointer;
    }

    button:hover {
      background-color: #0056b3;
    }

    #result {
      margin-top: 20px;
      font-weight: bold;
      color: green;
    }

    /* ===== HEADER SECTION STYLING ===== */
    .top-bar {
      background-color: #f9f9f9;
      font-size: 14px;
      padding: 5px 10px;
      display: flex;
      justify-content: space-between;
      align-items: center;
    }

    .left-links a,
    .right-options a {
      margin: 0 5px;
      text-decoration: none;
      color: #000;
    }

    .right-options {
      display: flex;
      align-items: center;
    }

    .search-box {
      padding: 3px 6px;
      margin: 0 5px;
      border-radius: 4px;
      border: 1px solid #ccc;
    }

    .header {
      border-bottom: 1px solid #ccc;
      background-color: #ffffff;
    }

    .main-header {
      display: flex;
      align-items: center;
      padding: 10px 15px;
      background-color: #fff;
    }

    .logo {
      height: 80px;
      margin-right: 20px;
    }

    .title-section h1 {
      font-size: 24px;
      margin: 0;
      color: #333;
    }

    .title-section h2 {
      font-size: 20px;
      margin: 5px 0 0;
      font-family: 'Noto Sans Devanagari', sans-serif;
      color: #333;
    }

     #excelTable table {
      border-collapse: collapse;
      width: 100%;
      margin-top: 20px;
    }

    #excelTable th, #excelTable td {
      border: 1px solid #ccc;
      padding: 8px;
    }  
  </style>
</head>
<body>

  <!-- HEADER SECTION -->
  <div class="header">
    <div class="top-bar">
      <div class="left-links">
        <a href="#">Skip to main content</a> |
        <a href="#">Screen Reader Access</a> |
        <a href="#" style="background:black; color:white; padding: 2px 5px; font-weight:bold;">A</a>
        <a href="#">A-</a>
        <a href="#">A</a>
        <a href="#">A+</a> |
        <a href="#">हिंदी</a>
      </div>
      <div class="right-options">
        <input type="text" placeholder="search" class="search-box">
        <a href="#"><i class="fab fa-facebook-f"></i></a>
        <a href="#"><i class="fab fa-x-twitter"></i></a>
        <a href="#"><i class="fab fa-youtube"></i></a>
        <a href="#"><i class="fab fa-instagram"></i></a>
        <a href="#"><i class="fab fa-linkedin-in"></i></a>
      </div>
    </div>

    <div class="main-header">
      <img src="csir_crri_logo.png" alt="CSIR-CRRI Logo" class="logo">
      <div class="title-section">
        <h1>CSIR - Central Road Research Institute</h1>
        <h2>सीएसआईआर - केंद्रीय सड़क अनुसंधान संस्थान</h2>
      </div>
    </div>
  </div>

  <!-- LOCATION SELECTOR FORM -->
  <h1>Location Selector</h1>

  <label for="state">State:</label>
  <select id="state" onchange="loadDistricts()">
    <option value="">-- Select State --</option>
  </select>

  <label for="district">District:</label>
  <select id="district" onchange="loadBlocks()">
    <option value="">-- Select District --</option>
  </select>

  <label for="block">Block:</label>
  <select id="block">
    <option value="">-- Select Block --</option>
  </select>

  <label for="districtmaps">District Map:</label>
  <select id="districtmaps">
    <option value="">-- Select District Map --</option>
  </select>

  <label for="blockmaps">Block Map:</label>
  <select id="blockmaps">
    <option value="">-- Select Block Map --</option>
  </select>

  <label for="roadPhase">Road Phase:</label>
  <select id="roadPhase">
    <option value="">-- Select Road Phase --</option>
    <option value="Phase I">Phase I</option>
    <option value="Phase II">Phase II</option>
    <option value="Phase III">Phase III</option>
    <option value="Phase IV">Phase IV</option>
  </select>
   
  <label for="roadLink">Road Link:</label>
  <select id="roadLink">
    <option value="">-- Select Road Link --</option>
  </select>

<!-- Excel File Upload and Preview (hidden by default) -->
<div id="excelUploadSection" style="display: none;">
  <label for="excelFile">Attach Excel file for Phase III:</label>
  <input type="file" id="excelFile" accept=".xlsx,.xls">
  <span id="excelFileName"></span>
</div>

<button onclick="showData()">View</button>
<div id="result"></div>
<div id="excelTable"></div>

<script src="script.js"></script>
  <script>

    // Excel File Preview Logic
    document.addEventListener('DOMContentLoaded', function() {
      const fileInput = document.getElementById('excelFile');
      const fileNameSpan = document.getElementById('excelFileName');
      const tableDiv = document.getElementById('excelTable');
      const roadPhaseSelect = document.getElementById('roadPhase');
      const excelSection = document.getElementById('excelUploadSection');

       // Show/hide Excel upload for Phase III
      roadPhaseSelect.addEventListener('change', function() {
        if (roadPhaseSelect.value === 'Phase III') {
          excelSection.style.display = '';
        } else {
          excelSection.style.display = 'none';
          fileInput.value = '';
          fileNameSpan.textContent = '';
          tableDiv.innerHTML = '';
        }
      });

    fileInput.addEventListener('change', function() {
      if (fileInput.files.length > 0) {
        const file = fileInput.files[0];
        fileNameSpan.textContent = `Selected file: ${file.name}`;
          // Read and display the Excel file
        const reader = new FileReader();
        reader.onload = function(e) {
          const data = e.target.result;
          const workbook = XLSX.read(data, {type: 'binary'});
          const sheetName = workbook.SheetNames[0];
          const worksheet = workbook.Sheets[sheetName];
          const html = XLSX.utils.sheet_to_html(worksheet);
          tableDiv.innerHTML = html;
        };
        reader.readAsBinaryString(file);
      } else {
        fileNameSpan.textContent = '';
        tableDiv.innerHTML = '';
      }
    });
  });
</script>

<script src="script.js"></script>
</body>
</html>
