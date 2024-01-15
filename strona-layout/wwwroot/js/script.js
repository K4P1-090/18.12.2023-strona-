function cdown()
{
        // Ustawienie docelowej daty - 24 grudnia bieżącego roku
    const targetDate = new Date(new Date().getFullYear(), 11, 24); // Miesiące są liczone od 0, więc 11 to grudzień

    // Funkcja odliczająca dni do 24 grudnia
    function countDaysUntilChristmas() {
    const today = new Date();
    const timeDiff = targetDate - today;
    
    // Konwersja różnicy czasu z milisekund na dni
    const daysDiff = Math.ceil(timeDiff / (1000 * 60 * 60 * 24));
    
    return daysDiff;
    }

    // Wywołanie funkcji i wyświetlenie wyniku
    document.getElementById("ileDni").innerHTML=(`Dni do 24 grudnia: ${countDaysUntilChristmas()}`);

}
