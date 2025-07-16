   // Full location data for all Indian states
const locationData = {
  "Andhra Pradesh": {
    "Chittoor": ["Puttur", "Madanapalle"],
    "Guntur": ["Tenali", "Mangalagiri"]
  },
  "Arunachal Pradesh": {
    "Itanagar": ["Naharlagun", "Chimpu"],   
    "Tawang": ["Lumla", "Zemithang"]
  },
  "Assam": {
    "Kamrup": ["Guwahati", "Rangia"],
    "Dibrugarh": ["Naharkatia", "Chabua"]
  },
  "Bihar": {
    "Patna": ["Danapur", "Phulwari"],
    "Gaya": ["Bodh Gaya", "Tekari"]
  },
  "Chhattisgarh": {
    "Raipur": ["Arang", "Tilda"],
    "Bilaspur": ["Takhatpur", "Bilha"]
  },
  "Goa": {
    "North Goa": ["Bicholim", "Mapusa"],
    "South Goa": ["Margao", "Canacona"]
  },
  "Gujarat": {
    "Ahmedabad": ["Daskroi", "Sanand"],
    "Surat": ["Choryasi", "Bardoli"]
  },
  "Haryana": {
    "Gurgaon": ["Sohna", "Pataudi"],
    "Hisar": ["Hansi", "Narnaund"]
  },
  "Himachal Pradesh": {
    "Shimla": ["Rohru", "Rampur"],
    "Kangra": ["Palampur", "Nurpur"]
  },
  "Jharkhand": {
    "Ranchi": ["Ormanjhi", "Bundu"],
    "Dhanbad": ["Baliapur", "Govindpur"]
  },
  "Karnataka": {
    "Bangalore": ["North", "South"],
    "Mysore": ["Chamundi", "Nanjangud"]
  },
  "Kerala": {
    "Thiruvananthapuram": ["Neyyattinkara", "Attingal"],
    "Kozhikode": ["Vadakara", "Koyilandy"]
  },
  "Madhya Pradesh": {
    "Bhopal": ["Huzur", "Berasia"],
    "Indore": ["Depalpur", "Sanwer"]
  },
  "Maharashtra": {
    "Mumbai": ["Andheri", "Borivali"],
    "Pune": ["Haveli", "Shirur"]
  },
  "Manipur": {
    "Imphal West": ["Lamphel", "Patsoi"],
    "Thoubal": ["Kakching", "Lilong"]
  },
  "Meghalaya": {
    "East Khasi Hills": ["Laitkroh","Mawlai","Mawpat","Mylliem","Sohiong","Mawphlang","Mawsynram","Pynursla","Mawkynrew","Shella Bollaganj","Mawryngkneng"],
    "West Garo Hills": ["Demdema", "Dadenggre","Gambegre","Dalu","Selsella","Tikrikilla","Rongram"],
    "East Garo Hills": ["Sonsek","Rongjeng","Samanda"],
    "North Garo Hills": ["Bajenadoba","Resubelpera","Khakutta"],
    "South Garo Hills": ["Baghmara","Chokpot","Gasuapara","Rongra"],
    "Ribhoi": ["Jirang","Umling","Umsning"],
    "South West Garo Hills": ["Betasing","Damalgre","Zikzak"],
    "South West Khasi Hills": ["Mawkyrwat","Ranikor"],
    "East Jaintia Hills": ["Khilehriat","Saipung"],
    "West Jaintia Hills": ["Amlarem","Laskein","Thadlaskein"],
    "West Khasi Hills": ["Mawshynryt","Nongstoin","Mawthadraiishan"]
  },
  "Mizoram": {
    "Aizawl": ["Darlawn", "Tlangnuam"],
    "Lunglei": ["Hnahthial", "Bunghmun"]
  },
  "Nagaland": {
    "Kohima": ["Chiephobozou", "Tseminyu"],
    "Dimapur": ["Medziphema", "Dhansiripar"]
  },
  "Odisha": {
    "Bhubaneswar": ["Jatni", "Chandaka"],
    "Cuttack": ["Banki", "Narsinghpur"]
  },
  "Punjab": {
    "Amritsar": ["Ajnala", "Majitha"],
    "Ludhiana": ["Samrala", "Jagraon"]
  },
  "Rajasthan": {
    "Jaipur": ["Amer", "Sanganer"],
    "Jodhpur": ["Osian", "Phalodi"]
  },
  "Sikkim": {
    "East Sikkim": ["Gangtok", "Pakyong"],
    "West Sikkim": ["Geyzing", "Yuksom"]
  },
  "Tamil Nadu": {
    "Chennai": ["Tondiarpet", "Perambur"],
    "Madurai": ["Thirumangalam", "Melur"]
  },
  "Telangana": {
    "Hyderabad": ["Charminar", "Serilingampally"],
    "Warangal": ["Hanamkonda", "Kazipet"]
  },
  "Tripura": {
    "Agartala": ["Mohanpur", "Jirania"],
    "Udaipur": ["Kakraban", "Rajnagar"]
  },
  "Uttar Pradesh": {
    "Lucknow": ["Bakshi Ka Talab", "Sarojini Nagar"],
    "Varanasi": ["Pindra", "Rohaniya"]
  },
  "Uttarakhand": {
    "Dehradun": ["Vikasnagar", "Raipur"],
    "Nainital": ["Haldwani", "Ramnagar"]
  },
  "West Bengal": {
    "Kolkata": ["Behala", "Salt Lake"],
    "Darjeeling": ["Kurseong", "Mirik"]
  }
};

// Static data for new dropdowns
const districtmaps  = ['East Khasi Hills','West Garo Hills','East Garo Hills','North Garo Hills','South Garo Hills','Ribhoi','South West Garo Hills','South West Khasi Hills','East Jaintia Hills','West Jaintia Hills','West Khasi Hills'];
const districtmapsLinks = {
  "Meghalaya": {
  "East Khasi Hills": "https://drive.google.com/file/d/1J9OZc_psyx7n8j24Hw6Z2IbHTgu7631a/view?usp=sharing",
  "West Garo Hills": "https://drive.google.com/file/d/1kmpRSp32PojMAcA2NpG14hfqVbEiYVsc/view?usp=sharing",
  "East Garo Hills": "https://drive.google.com/file/d/17qOCNJFjbdaFbH83a2mqgfkR0Ti5aTHn/view?usp=sharing",
  "North Garo Hills": "https://drive.google.com/file/d/17MJdirN1E0hRMVKGQta4C5Nt4PGfy-GG/view?usp=sharing",
  "South Garo Hills": "https://drive.google.com/file/d/1PoWdCjyCXB0ne-wS2LLL65o7QUxQpwTx/view?usp=sharing",
  "Ribhoi": "https://drive.google.com/file/d/13q70657xe8sFhETywzLr0aEWOp1-J6tQ/view?usp=sharing",
  "South West Garo Hills": "https://drive.google.com/file/d/1fd1D1V2PWZfWA2YG2UpQ4N9rxO5qqJVR/view?usp=sharing",
  "South West Khasi Hills": "https://drive.google.com/file/d/14EiDtPOgR3iXXf-n2Pr4BRGyEJavzbXq/view?usp=sharing",
  "East Jaintia Hills": "https://drive.google.com/file/d/177mwNope3xBG-IN_A3nuAf9pD4dXDMnr/view?usp=sharing",
  "West Jaintia Hills": "https://drive.google.com/file/d/1WWgfvVrE5pflaSLTzv_dIP3d02a0x3a3/view?usp=sharing",
  "West Khasi Hills": "https://drive.google.com/file/d/18rPT1Va37N2ZUwIjkPul2d5GvZPmyUr4/view?usp=sharing",
  }
};
const blockMapsLinks = {
  "Meghalaya": {
    "East Khasi Hills": {
      "Laitkroh": "https://drive.google.com/file/d/123Ci5DWDutHa9xnyB3V2AcWBdtX2kiND/view?usp=sharing",
      "Mawlai": "https://drive.google.com/file/d/1pLAi3TZw1JyuPY3eTA-AHuiKddYuWT-r/view?usp=sharing",
      "Mawpat": "https://drive.google.com/file/d/1cHGL4uIZCvEbGbcc2vEet2VL8-tJMJY2/view?usp=sharing",
      "Mylliem": "https://drive.google.com/file/d/1MtnxE-u9L4sSPchuAO2219unLazpw8hL/view?usp=sharing",
      "Sohiong": "https://drive.google.com/file/d/1_awKpR6oUnihGE1sItk3qZHkjWXCPN59/view?usp=sharing",
      "Mawphlang": "https://drive.google.com/file/d/1ABYk9rbqAZGnrOwcjUzn66vmRFw2JJoK/view?usp=sharing",
      "Mawsynram": "https://drive.google.com/file/d/1FMvl-wC_Zmq6ggDJH4gDd8p5zVc9dKJA/view?usp=sharing",
      "Pynursla": "https://drive.google.com/file/d/1dH1Vhwv-9JXuAzMz94o2Tg2IVKzWap1i/view?usp=sharing",
      "Mawkynrew": "https://drive.google.com/file/d/1ADYFcINLvEGVkXsRgR2zcheDSxJS_1Bw/view?usp=sharing",
      "Shella Bollaganj": "https://drive.google.com/file/d/1ife0MmbyX6cCSNNupCy2rpZN6ESj1P43/view?usp=sharing",
      "Mawryngkneng": "https://drive.google.com/file/d/1XVM0LUMGuo4gasDR3EgjhGFNyuA0ngS-/view?usp=sharing",
    },
    "West Garo Hills": {
      "Demdema": "https://drive.google.com/file/d/1EHg3o8u8BRXJjpsg9CHN2J13HjsXIuR8/view?usp=sharing",
      "Dadenggre": "https://drive.google.com/file/d/1GsLhOIle4MFkU-jGZf16Z8E8ellGskuV/view?usp=sharing",
      "Gambegre": "https://drive.google.com/file/d/1CcGy1KaAyxBxewlEJFU9ZahV1lxLSo4G/view?usp=sharing",
      "Dalu": "https://drive.google.com/file/d/18MFpF5G2VtG6XTOssKiXBULzSOsi7b0K/view?usp=sharing",
      "Selsella": "https://drive.google.com/file/d/1ATPetGwE0vU8_g9nP2oXZRfMnjGC6wxJ/view?usp=sharing",
      "Tikrikilla": "https://drive.google.com/file/d/16vbqA7Y13gl6Gw4sukZ7SsjD28hZJx8l/view?usp=sharing",
      "Rongram": "https://drive.google.com/file/d/117MSCG6tPoTgIHNVkWl5PLaY-HuEeOMG/view?usp=sharing",
    },  
    "East Garo Hills":  {
      "Sonsek": "https://drive.google.com/file/d/1Xwdidsc3KiJWtivoiPuTsDReuj1tDH6V/view?usp=sharing",
      "Rongjeng": "https://drive.google.com/file/d/1dwyBmDGkMbI0zq-czLpTB7OoI8VlUn3b/view?usp=sharing",
      "Samanda": "https://drive.google.com/file/d/1u5zXSOGWlJTU5EdyJ_SLFE6wGeB5LUl5/view?usp=sharing",
    },
    "North Garo Hills": { 
      "Bajenadoba": "https://drive.google.com/file/d/18Eh2PExWYa0nyVlsrSJ9fR7YWS0HFlf8/view?usp=sharing",
      "Resubelpera": "https://drive.google.com/file/d/1sIur1JZ9RMB8x8tALDJH8ZoMWOr6XmJN/view?usp=sharing",
      "Khakutta": "https://drive.google.com/file/d/1R7yHifF0uMTtFs_l5Lp12EHGvEAyyeHy/view?usp=sharing",
    },
    "South Garo Hills": {
     "Baghmara": "https://drive.google.com/file/d/1sUcWPFbyntjsa0elpZ5eGdRMitm28PNo/view?usp=sharing",
     "Chokpot": "https://drive.google.com/file/d/1Igt-OoQeKQ9eVo8SB78R_Txk6-4FsGmo/view?usp=sharing",
     "Gasuapara": "https://drive.google.com/file/d/1z6_0iN5XZbPN5RRN9RSXmNQyyLhqN0mI/view?usp=sharing",
     "Rongra": "https://drive.google.com/file/d/16uOss2kp1zAtuxk_eGCB9JbCKtSBq0p0/view?usp=sharing",  
    },
    "Ribhoi": {
      "Bhoi Rymbong": "https://drive.google.com/file/d/1_AYNq-JUCqbw9xxWvHGmgBevOIxNVurh/view?usp=sharing",
      "Jirang": "https://drive.google.com/file/d/1CpaRM2AXsYPrHpx_nSLkb_TTya17WwUD/view?usp=sharing",
      "Umling": "https://drive.google.com/file/d/1a024nAw5VhpAEJwaaH6za08zvFdvwIEo/view?usp=sharing",
      "Umsning": "https://drive.google.com/file/d/1munFEx6_ub_NuzmgR1TOzPX8ZY38UosF/view?usp=sharing",
    },
     "South West Garo Hills": {
      "Betasing": "https://drive.google.com/file/d/1ubkAseTVxGs_l8yQCwfUh1C82lIQeKuh/view?usp=sharing",
      "Damalgre": "https://drive.google.com/file/d/13me0r5dKyu2Axf5bsNIEGKJkorg0jnfk/view?usp=sharing",
      "Zikzak": "https://drive.google.com/file/d/1eIu7mgkQsWQEpuVQJ33u5MHCEq4d08v6/view?usp=sharing",
    },
     "South West Khasi Hills": {
      "Mawkyrwat": "https://drive.google.com/file/d/1Nks37ApWdRcCKhQVq36Nk50btej5igMZ/view?usp=sharing",
      "Ranikor": "https://drive.google.com/file/d/1eM963IQ89ZlQ_8ewwAWNWErLtigaJ-vV/view?usp=sharing",
    },
     "East Jaintia Hills": {
      "Khilehriat": "https://drive.google.com/file/d/1AD4Dc2vB9hT1SRkFK1_RYDemjhfBubta/view?usp=sharing",
      "Saipung": "https://drive.google.com/file/d/1b-aioBAvXY8KVaWpNbkIEZzfrLttZFS1/view?usp=sharing",
    },
     "West Jaintia Hills": {
      "Amlarem": "https://drive.google.com/file/d/1PKTKpP47QcTf0oDSe8nY9qgX9d2MTaMp/view?usp=sharing",
      "Laskein": "https://drive.google.com/file/d/1kpcXSLsJOuMo__2E7JBlQ8I8FEOpE0If/view?usp=sharing",
      "Thadlaskein": "https://drive.google.com/file/d/1i4hrUi4ZJdhm_YMi70Oq9epdZqblKkHr/view?usp=sharing",
    },
     "West Khasi Hills": {
      "Mairang": "https://drive.google.com/file/d/11myg8i3mBOhZC7JtK7VjNc4gFG04RvMm/view?usp=sharing",
      "Mawshynryt": "https://drive.google.com/file/d/1ucayL15BKHBc9r0YKwPwJxpMf7Z_QR3y/view?usp=sharing",
      "Nongstoin": "https://drive.google.com/file/d/168H2T0yFm5Hqd9-y6ONzNz0lxz1auS3I/view?usp=sharing",
      "Mawthadraiishan": "https://drive.google.com/file/d/1Enk4T3ar2KtigloOCAEYAGGfRyIIoASX/view?usp=sharing",

    },
  }
};
const roadPhases = ['Phase I', 'Phase II', 'Phase III', 'Phase IV'];
const phase3BlockLinks = {
   "Meghalaya": {
    "East Khasi Hills": {
      "Laitkroh": "https://view.officeapps.live.com/op/view.aspx?src=https://raw.githubusercontent.com/BVNeha/indian-map-selector/main/LAITKROH.xls",
      "Mawlai": "file:///C:/Users/nehab/Downloads/Zipped%20PDF%20Files%20(27)%20(3)/MawlaiA0-1.pdf",
      "Mawpat": "file:///C:/Users/nehab/Downloads/Zipped%20PDF%20Files%20(28)%20(2)/MawpatA0-1.pdf",
      "Mylliem": "file:///C:/Users/nehab/Downloads/Zipped%20PDF%20Files%20(49)%20(1)/MYLLIEMA0-1.pdf",
      "Sohiong": "file:///C:/Users/nehab/Downloads/Zipped%20PDF%20Files%20(38)%20(2)/SohiongA0-1.pdf",
      "Mawphlang": "file:///C:/Users/nehab/Downloads/Zipped%20PDF%20Files%20(29)%20(2)/MawphlangA0-1.pdf",
      "Mawsynram": "file:///C:/Users/nehab/Downloads/Zipped%20PDF%20Files%20(52)%20(2)/mawsynramA0-1.pdf",
      "Pynursla": "file:///C:/Users/nehab/Downloads/Zipped%20PDF%20Files%20(47)%20(2)/Pynursla-1.pdf",
      "Mawkynrew": "file:///C:/Users/nehab/Downloads/Zipped%20PDF%20Files%20(25)%20(2)/Mawkynrew-1.pdf",
      "Shella Bollaganj": "file:///C:/Users/nehab/Downloads/Zipped%20PDF%20Files%20(39)%20(2)/ShellaBholaghanjA0-1.pdf",
      "Mawryngkneng": "file:///C:/Users/nehab/Downloads/Zipped%20PDF%20Files%20(30)%20(2)/Mawryngkeneng-1.pdf",
    },
    "East Garo Hills":  {
      "Sonsek": "https://raw.githubusercontent.com/BVNeha/indian-map-selector/main/EGH%20Complete/Sonsak-New%20A0-1.pdf",
      "Rongjeng": "https://raw.githubusercontent.com/BVNeha/indian-map-selector/main/EGH%20Complete/Dambb%20Rongjong/Dambb%20Rongjong.xlsx",
      "Samanda": "https://raw.githubusercontent.com/BVNeha/indian-map-selector/main/EGH%20Complete/Samanda-A0-1.pdf",
    },
  }
}; 
const roadLinks  = ['RL001', 'RL002', 'RL003', 'RL004'];

// Utility function to populate dropdowns
function populateDropdown(id, values, placeholder) {
  const select = document.getElementById(id);
  select.innerHTML = `<option value="">-- ${placeholder} --</option>`;
  values.forEach(val => select.add(new Option(val, val)));
}
const blockmaps = Array.from(
  new Set(
    Object.values(locationData["Meghalaya"]).flat()
  )
).sort();

// On page load, populate dropdowns
window.onload = () => {
  populateDropdown('state', Object.keys(locationData).sort(), 'Select State');
  populateDropdown('districtmaps', districtmaps, 'Select districtmaps');
  populateDropdown('blockmaps', blockmaps, 'Select blockmaps');
  populateDropdown('roadPhase', roadPhases, 'Select Road Phase');
  populateDropdown('roadLink', roadLinks, 'Select Road Link');
};

// Load districts when a state is selected
function loadDistricts() {
  const state = document.getElementById('state').value;
  const districts = state ? Object.keys(locationData[state]).sort() : [];
  populateDropdown('district', districts, 'Select District');
  populateDropdown('block', [], 'Select Block');
}

// Load blocks when a district is selected
function loadBlocks() {
  const state = document.getElementById('state').value;
  const district = document.getElementById('district').value;
  const blocks = (state && district) ? locationData[state][district].sort() : [];
  populateDropdown('block', blocks, 'Select Block');
}

// Display selected data
function showData() {
  const state = document.getElementById('state').value;
  const district = document.getElementById('district').value;
  const block = document.getElementById('block').value;
  const districtmaps = document.getElementById('districtmaps').value;
  const blockmap = document.getElementById('blockmaps').value;
  const phase = document.getElementById('roadPhase').value;
  const link = document.getElementById('roadLink').value;

  if (!state || !district || !block || !districtmaps || !blockmap || !phase || !link) {
    alert("Please select all fields.");
    return;
  }

  // Get the District Map link if available
  let districtMapLink = "";
  if (
    districtmapsLinks[state] &&
    districtmapsLinks[state][districtmaps]
  ) {
    districtMapLink = districtmapsLinks[state][districtmaps];
  }

  // Get the Block Map link if available
  let blockMapLink = "";
  if (
    blockMapsLinks[state] &&
    blockMapsLinks[state][districtmaps] &&
    blockMapsLinks[state][districtmaps][blockmap]
  ) {
    blockMapLink = blockMapsLinks[state][districtmaps][blockmap];
  }

  let html = `<div>
    <p>Showing data for:</p>
    <ul>
      <li>District: ${district}</li>
      <li>Block: ${block}</li>
      <li>Districtmap: ${districtmaps}</li>
      <li>Blockmap: ${blockmap}</li>
      <li>Road Phase: ${phase}</li>
      <li>Road Link: ${link}</li>
    </ul>
   `;

  if (districtMapLink) {
    html += `<div>
      <strong>District Map:</strong><br>
      <img src="${districtMapLink}" alt="District Map" style="max-width:300px;max-height:300px;"><br>
      <a href="${districtMapLink}" target="_blank">Open Map</a>
    </div>`;
  }

  if (blockMapLink) {
    html += `<div>
      <strong>Block Map:</strong><br>
      <img src="${blockMapLink}" alt="Block Map" style="max-width:300px;max-height:300px;"><br>
      <a href="${blockMapLink}" target="_blank">Open Map</a>
    </div>`;
  }

  if (phase === "Phase III") {
    html += `<div>
      <strong>Download Phase III Excel Sheet:</strong><br>
      <a href="road_phase_3.xlsx" download>Click here to download Excel Sheet</a>
    </div>`;
  }

  html += "</div>";

  document.getElementById('result').innerHTML = html;
}