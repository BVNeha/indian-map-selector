/* Body and fonts */
body {
  font-family: Arial, sans-serif;
  margin: 0;
  padding: 0;
}

/* Header */
.header {
  border-bottom: 1px solid #ccc;
  background-color: #fff;
}

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

.font-button.black {
  background: black;
  color: white;
  padding: 2px 5px;
  font-weight: bold;
}

.search-box {
  padding: 3px 6px;
  border-radius: 4px;
  border: 1px solid #ccc;
}

.main-header {
  display: flex;
  align-items: center;
  padding: 10px 15px;
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

/* Location Selector Layout */
.location-selector {
  padding: 20px;
}

.location-selector label {
  display: block;
  margin-top: 10px;
}

.location-selector select,
.location-selector button {
  width: 100%;
  max-width: 300px;
  padding: 5px;
  margin-top: 5px;
}

#result {
  margin-top: 20px;
  font-weight: bold;
  color: green;
}
