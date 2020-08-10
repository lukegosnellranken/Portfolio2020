class Weather {
    constructor(city, state) {
        this.apiKey = '3457babe69cb0a03527083d081f92105';
        this.city = city;
        this.state = state;
    }

    // Fetch weather from API
    async getWeather() {
        const response = await fetch(`https://api.openweathermap.org/data/2.5/weather?q=${this.city},${this.state}&units=imperial&appid=${this.apiKey}`);
    
        const responseData = await response.json();

        return responseData;
    }

    // Change location
    changeLocation(city, state) {
        this.city = city;
        this.state = state;
        console.log(state);
    }
}