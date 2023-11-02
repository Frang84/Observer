
using ConsoleApp1;
using ConsoleApp2;

WeatherData wd = new WeatherData(75,23,1013);
StatisticsDisplay sd = new StatisticsDisplay(wd);
CurrentConditions cd = new CurrentConditions(wd);
ForecastDisplay forecast = new ForecastDisplay(wd);

wd.SetParams(1, 1, 1);




