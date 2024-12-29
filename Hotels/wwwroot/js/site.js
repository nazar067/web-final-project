function toggleGalleryCarousel(galleryId, carouselId, button) {
    const gallery = document.getElementById(galleryId);
    const carousel = document.getElementById(carouselId);

    if (gallery.style.display === "none") {
        gallery.style.display = "block";
        carousel.style.display = "none";
        button.textContent = "Switch to Carousel";
    } else {
        gallery.style.display = "none";
        carousel.style.display = "block";
        button.textContent = "Switch to Gallery";
    }
}
