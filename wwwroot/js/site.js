// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const GOOGLE_MAPS_API_KEY = "AIzak-O6hJs7C5Tyfv9V3w8WagW3h8xCDXp4GGg";

function loadHouseMap() {
    const script = document.createElement("script");
    script.src = "https://maps.googleapis.com/maps/api/js?key=" + GOOGLE_MAPS_API_KEY;
    document.head.appendChild(script);
}
