class UI {
    constructor() {
        this.location = document.getElementById('w-location');
        this.description = document.getElementById('w-desc');
        this.string = document.getElementById('w-string');
        this.details = document.getElementById('w-details');
        this.icon = document.getElementById('w-icon');
        this.humidity = document.getElementById('w-humidity');
        this.feelsLike = document.getElementById('w-feels-like');
        this.dewpoint = document.getElementById('w-dewpoint');
        this.wind = document.getElementById('w-wind');
    }

    paint(weather) {
        const weatherJS = new Weather(weatherLocation.city, weatherLocation.state);
        let state;
        if(localStorage.getItem('state') === null){
            state = weatherJS.state;
        } else {
            state = localStorage.getItem('state');
        }
        let capitalizedState = state.charAt(0).toUpperCase();
        state = state.replace(state.charAt(0), capitalizedState);
        console.log(state);
        this.location.textContent = weather.name + ', ' +state;
        this.icon.setAttribute(
            'src',
            `http://openweathermap.org/img/wn/${weather.weather[0].icon}@2x.png`
        );
        this.description.textContent = weather.weather[0].description;
        this.string.textContent = weather.main.temp + '°F';
        this.humidity.textContent = `Relative Humidity: ${weather.main.humidity}%`;
        this.feelsLike.textContent = `Feels Like: ${weather.main.feels_like}°F`;
        this.dewpoint.textContent = `Wind Direction: ${weather.wind.deg} degrees`;
        this.wind.textContent = `Wind Speed: ${weather.wind.speed} mph`;
    }
}