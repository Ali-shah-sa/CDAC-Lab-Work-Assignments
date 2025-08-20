L.Control.CustomControl = L.Control.extend({
  onAdd: function (map) {
    const controlDiv = L.DomUtil.create("div", "custom-control");
    controlDiv.innerHTML = '<button id="resetMap">Reset Map</button>';
    controlDiv.firstChild.onclick = function () {
      map.setView([51.505, -0.09], 13); // Reset to initial view
    };
    return controlDiv;
  },
  onRemove: function (map) {
    // Remove control if necessary
  },
});

map.addControl(new L.Control.CustomControl());
const layer1 = L.layerGroup().addTo(map);
const layer2 = L.layerGroup().addTo(map);

// Add markers to layer1
L.marker([51.5, -0.09]).addTo(layer1).bindPopup("Layer 1 Marker");

// Add markers to layer2
L.marker([51.51, -0.1]).addTo(layer2).bindPopup("Layer 2 Marker");

// Control for layer switching
const baseMaps = {
  "Layer 1": layer1,
  "Layer 2": layer2,
};

L.control.layers(null, baseMaps).addTo(map);
const geojsonFeature = {
  type: "Feature",
  properties: {
    name: "My GeoJSON Feature",
  },
  geometry: {
    type: "Point",
    coordinates: [-0.09, 51.5],
  },
};

L.geoJSON(geojsonFeature).addTo(map).bindPopup("GeoJSON Feature");
fetch("https://api.example.com/data")
  .then((response) => response.json())
  .then((data) => {
    data.forEach((item) => {
      L.marker([item.lat, item.lng]).addTo(map).bindPopup(item.info);
    });
  });
  const savedView = JSON.parse(localStorage.getItem('mapView'));
  if (savedView) {
      map.setView(savedView.center, savedView.zoom);
  }
  
  map.on('moveend', function() {
      const center = map.getCenter();
      const zoom = map.getZoom();
      localStorage.setItem('mapView', JSON.stringify({ center, zoom }));
  });
  map.on('touchstart', function(e) {
    console.log('Touch started at:', e.latlng);
});
document.getElementById('loading').style.display = 'block';
// Fetch data or perform actions
document.getElementById('loading').style.display = 'none';
document.getElementById('loading').style.display = 'block';
fetch('https://api.example.com/data')
    .then(response => {
        if (!response.ok) throw new Error('Network response was not ok');
        return response.json();
    })
    .catch(error => {
        console.error('There was a problem with the fetch operation:',
            error);
            const customProjection = L.Proj.proj4('EPSG:3857');
const customMap = L.map('map', {
    crs: customProjection
}).setView([51.505, -0.09], 13);
const customTileLayer = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19
}).addTo(customMap);
const customMarker = L.marker([51.5, -0.09]).addTo(customMap);
customMarker.bindPopup('Custom Map Marker');
const customGeojsonFeature = {
    type: 'Feature',
    properties: {
        name: 'My Custom GeoJSON Feature'
    },
    geometry: {
        type: 'Point',
        coordinates: [-0.09, 51.5]
    }
};
L.geoJSON(customGeojsonFeature).addTo(customMap).bindPopup('Custom GeoJSON Feature');


const customControl = L.control({position: 'topright'});
customControl.onAdd = function(map) {
    const controlDiv = L.DomUtil.create('div', 'custom-control');
    controlDiv.innerHTML = '<button id="resetMap">Reset Map</button>';
    controlDiv.firstChild.onclick = function() {
        map.setView([51.505, -0.09], 13);
    };
    return controlDiv;
};
customControl.addTo(customMap);
function loginUser (username, password) {
    // Simulate an API call for user authentication
    fetch('/api/login', {
        method: 'POST',
        body: JSON.stringify({ username, password }),
        headers: { 'Content-Type': 'application/json' }
    })
    .then(response => response.json())
    .then(data => {
        if (data.success) {
            alert('Login successful!');
            // Store user session
        } else {
            alert('Login failed. Please try again.');
        }
    });
}
document.getElementById('loginForm').addEventListener('submit', function(event) {
    event.preventDefault();
    const username = document.getElementById('username').value;
    const password = document.getElementById('password').value;
    loginUser(username, password);
});
const map = L.map('map').setView([51.505, -0.09], 13);
L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19
}).addTo(map);
const layer1 = L.layerGroup().addTo(map);
const layer2 = L.layerGroup().addTo(map);
L.marker([51.5, -0.09]).addTo(layer1).bindPopup('Layer 1 Marker');
L.marker([51.51, -0.1]).addTo(layer2).bindPopup('Layer 2 Marker');
const baseMaps = {
    'Layer 1': layer1,
    'Layer 2': layer2
};
L.control.layers(null, baseMaps).addTo(map);
const geojsonFeature = {
    type: 'Feature',
    properties: {
        name: 'My GeoJSON Feature'
    },
    geometry: {
        type: 'Point',
        coordinates: [-0.09, 51.5]
    }
};
L.geoJSON(geojsonFeature).addTo(map).bindPopup('GeoJSON Feature');
fetch('https://api.example.com/data')
    .then(response => response.json())
    .then(data => {
        data.forEach(item => {
            L.marker([item.lat, item.lng]).addTo(map).bindPopup(item.info);
        });
    });
const savedView = JSON.parse(localStorage.getItem('mapView'));
if (savedView) {
    map.setView(savedView.center, savedView.zoom);
}
map.on('moveend', function() {
    const center = map.getCenter();
    const zoom = map.getZoom();
    localStorage.setItem('mapView', JSON.stringify({ center, zoom }));
});
map.on('touchstart', function(e) {
    console.log('Touch started at:', e.latlng);
});
document.getElementById('loading').style.display = 'block';
// Fetch data or perform actions
document.getElementById('loading').style.display = 'none';
document.getElementById('loading').style.display = 'block';
fetch('https://api.example.com/data')
    .then(response => {
        if (!response.ok) throw new Error('Network response was not ok');
        return response.json();
    })
    .catch(error => {
        console.error('There was a problem with the fetch operation:',
            error);
    });