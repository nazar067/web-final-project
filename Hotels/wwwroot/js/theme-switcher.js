document.addEventListener("DOMContentLoaded", function () {
    const themeStylesheet = document.getElementById("theme-stylesheet");
    const toggleButton = document.getElementById("theme-toggle");

    // Проверка сохранённой темы
    const savedTheme = localStorage.getItem("theme") || "/css/site.css";
    themeStylesheet.href = savedTheme;

    // Переключение тем
    toggleButton.addEventListener("click", function () {
        if (themeStylesheet.href.includes("site.css")) {
            themeStylesheet.href = "/css/dark-theme.css";
            localStorage.setItem("theme", "/css/dark-theme.css");
        } else {
            themeStylesheet.href = "/css/site.css";
            localStorage.setItem("theme", "/css/site.css");
        }
    });
});
