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
    "East Khasi Hills": "https://drive.google.com/file/d/1n5TImd7QbwQN-Quy2OtQM0A9Smd3xwaN/view?usp=drive_link",
    "West Garo Hills": "https://drive.google.com/file/d/1n3k7nNS3RdQUxUJwLteJrELvVtywrEIE/view?usp=drive_link",
    "East Garo Hills": "https://drive.google.com/file/d/1pwHWH0lEnREkMORmiZCG-f2o6cC5SSzz/view?usp=drive_link",
    "North Garo Hills": "https://drive.google.com/file/d/1yDcTrwUz2Ot_8Rzs83hAwGTjYIOGjyDt/view?usp=drive_link",
    "South Garo Hills": "https://drive.google.com/file/d/1AFztJat9F0jf258QOmXdV6BNqafbttk8/view?usp=drive_link",
    "Ribhoi": "https://drive.google.com/file/d/1ZyC0kxR13FWpjcPPQ3W7GUkt9VW-G1iZ/view?usp=drive_link",
    "South West Garo Hills": "https://drive.google.com/file/d/1oImda6dTgT_ICWiDUvHYXa394rlKRZZg/view?usp=drive_link",
    "South West Khasi Hills": "https://drive.google.com/file/d/18oSXq_QH6I0X5OGCNl8aHR6RavOKmoXG/view?usp=drive_link",
    "East Jaintia Hills": "https://drive.google.com/file/d/1T1OZvh-mEDLKpnuF4b-vy8gFt9pyrHy1/view?usp=drive_link",
    "West Jaintia Hills": "https://drive.google.com/file/d/1s8BwyrRnruZGTCGffGXUJME8GUVYOP6y/view?usp=drive_link",
    "West Khasi Hills": "https://drive.google.com/file/d/1ce7vdAdGkVy354r2rOSSstk91hd1f3oa/view?usp=drive_link",
  }
};
const blockMapsLinks = {
  "Meghalaya": {
    "East Khasi Hills": {
      "Laitkroh": "https://drive.google.com/file/d/17SbOzYbtac2gePTGDn7XlpChfRaG2EQZ/view?usp=drive_link",
      "Mawlai": "https://drive.google.com/file/d/1J-wz4yJxELJYNyu6RuUccRrrbuyEUTzN/view?usp=drive_link",
      "Mawpat": "https://drive.google.com/file/d/1bWCVzJCGUGNeuMG-e-_bVHVlI9MfGrff/view?usp=drive_link",
      "Mylliem": "https://drive.google.com/file/d/1KjnFx94_vZ4ZlLrpr5lrlhWaWWyXPfsj/view?usp=drive_link",
      "Sohiong": "https://drive.google.com/file/d/1vVmIkZv91zweVZo9rwbzzD78uk7QJkxD/view?usp=drive_link",
      "Mawphlang": "https://drive.google.com/file/d/1DvDcM60j1OKsOIr4PgRosQjp7eRRjQOC/view?usp=drive_link",
      "Mawsynram": "https://drive.google.com/file/d/1JfSHWgZueC0PoEevjx7ZOWxCvxz5SY5V/view?usp=drive_link",
      "Pynursla": "https://drive.google.com/file/d/1btxxM5z_PDGjrem_NntMO1EPdRrXoW16/view?usp=drive_link",
      "Mawkynrew": "https://drive.google.com/file/d/11fJwvJ3cC3bruDh1OoNi-W1yDv6Aw6aR/view?usp=drive_link",
      "Shella Bollaganj": "https://drive.google.com/file/d/1uaq8mr4nOGNEhmXlVI_1ONaZ9eBZAp4v/view?usp=drive_link",
      "Mawryngkneng": "https://drive.google.com/file/d/1uz86RMyGHWu39dXw17TF_N3foCySMftM/view?usp=drive_link",
    },
    "West Garo Hills": {
      "Demdema": "https://drive.google.com/file/d/1TPYv-moRQf1tf4Ski5x15xPluAtJIOTC/view?usp=drive_link",
      "Dadenggre": "https://drive.google.com/file/d/1uUpT4M4GaSlUrm3Ja84xFZm7NBxY3I7e/view?usp=drive_link",
      "Gambegre": "https://drive.google.com/file/d/1rgFzU_XsPC2rCZG-Q5d4OTHjBfZBo5DD/view?usp=drive_link",
      "Dalu": "https://drive.google.com/file/d/1RowxE7mWb6x36kZpvY7snYKEHW8N_2gs/view?usp=drive_link",
      "Selsella": "https://drive.google.com/file/d/1g3k2pFuZikVqsdcy_KfKUpFBf-5e2K3j/view?usp=drive_link",
      "Tikrikilla": "https://drive.google.com/file/d/1LGD05jTk9DMMyje_KFIY5tia8dcFv9Ps/view?usp=drive_link",
      "Rongram": "https://drive.google.com/file/d/1RzEdjENQAF86xcmFbZ18lYpYUOC00VZw/view?usp=drive_link",
    },  
    "East Garo Hills":  {
      "Sonsek": "https://drive.google.com/file/d/1k6_HHw8l6iYqcDMQUaRI5X0-NPtJCAxy/view?usp=drive_link",
      "Rongjeng": "https://drive.google.com/file/d/1fkjf6NoLnOrQTneBXuqX5B57dGBdi660/view?usp=drive_link",
      "Samanda": "https://drive.google.com/file/d/1PUPIxpzt7DzSgdxUKyG9-VGZ-W_kFMAo/view?usp=drive_link",
    },
    "North Garo Hills": { 
      "Bajenadoba": "https://drive.google.com/file/d/1459flyqB4qFlWI3Reonh5kX6nzM7et8I/view?usp=drive_link",
      "Resubelpera": "https://drive.google.com/file/d/1nmGseSkB7HsGRsMCMHcVAv-vOhqQQ6wt/view?usp=drive_link",
      "Khakutta": "https://drive.google.com/file/d/1B5kbI9cPEzBNPrpTz0jZ9G7d20HVthfQ/view?usp=drive_link",
    },
    "South Garo Hills": {
      "Baghmara": "https://drive.google.com/file/d/1c9L8g7BRd6HHCMwWjNEXoqjxplVQy_LC/view?usp=drive_link",
      "Chokpot": "https://drive.google.com/file/d/1AP7SWRX_OOOBfUs3dQsE8OdNS3vgDTdi/view?usp=drive_link",
      "Gasuapara": "https://drive.google.com/file/d/1x_7c9fYa_v3NG4Pu4l2D0LmZKwj3t3aR/view?usp=drive_link",
      "Rongra": "https://drive.google.com/file/d/1VyeTY9Z8zx_wGt1CjFB95e8fhkX2t-LY/view?usp=drive_link",  
    },
    "Ribhoi": {
      "Jirang": "https://drive.google.com/file/d/1rZ5q0IUPuMstJrdYmDWSEove5gtw3wsZ/view?usp=drive_link",
      "Umling": "https://drive.google.com/file/d/1gfNB890qNyOfStwQV4vukBC6xzytMyFk/view?usp=drive_link",
      "Umsning": "https://drive.google.com/file/d/1eQDC7O8MVfV1QHQDDyAGhy2vU4ofNqPe/view?usp=drive_link",
    },
     "South West Garo Hills": {
      "Betasing": "https://drive.google.com/file/d/1P9x_zleczsNmGFiAsyAK_sWjSHk65SuS/view?usp=drive_link",
      "Damalgre": "https://drive.google.com/file/d/1JhhR811Z6RiGCzTul9ylmZmmajX9g65H/view?usp=drive_link",
      "Zikzak": "https://drive.google.com/file/d/1Unt8eEvQ5l80y4U2WRTTMoQ7htTPIR73/view?usp=drive_link",
    },
     "South West Khasi Hills": {
      "Mawkyrwat": "https://drive.google.com/file/d/1TotPfgngUjA49rnUssUy5yYkJ99Ro5rj/view?usp=drive_link",
      "Ranikor": "https://drive.google.com/file/d/1MoQeNziRrI_x_lSUEF85xFStQImFr_PJ/view?usp=drive_link",
    },
     "East Jaintia Hills": {
      "Khilehriat": "https://drive.google.com/file/d/1Lck99inL2fpfxnI_2nxwkxaUDFOdyclI/view?usp=drive_link",
      "Saipung": "https://drive.google.com/file/d/1HnQngEqmPk19WFRMm4amGBYf0huQrsC8/view?usp=drive_link",
    },
     "West Jaintia Hills": {
      "Amlarem": "https://drive.google.com/file/d/1g7TphrXezBHRVbJ7izrJPw4a3v5PD4N6/view?usp=drive_link",
      "Laskein": "https://drive.google.com/file/d/1vQk2i83e1ScFMyfaCh9QCVGMfUEEuYNR/view?usp=drive_link",
      "Thadlaskein": "https://drive.google.com/file/d/1Ki-z8laV-9ps77Lfd1SEoJurQ5-uu5es/view?usp=drive_link",
    },
     "West Khasi Hills": {
      "Mawshynryt": "https://drive.google.com/file/d/1CElq_u3yhJqrKeoF_mddmGsg3WiauSqR/view?usp=drive_link",
      "Nongstoin": "https://drive.google.com/file/d/1J2iU1ySN1X0vT66dvNcpuAGIBKlbSCsc/view?usp=drive_link",
      "Mawthadraiishan": "https://drive.google.com/file/d/1SpOvRalJmAabkilZAjBhnG51RZ5r4BPZ/view?usp=drive_link",
    },
  }
};
const roadPhases = ['Phase I', 'Phase II', 'Phase III', 'Phase IV'];
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

  document.getElementById('result').innerText =
   `Showing data for:\n` +
   `District: ${district}\n` +
   `Block: ${block}\n` +
   `Districtmap: ${districtmaps}\n` +
   `blockmap: ${blockmaps}\n` +
   `Road Phase: ${phase}\n` +
   `Road Link: ${link}\n `;
    
}
