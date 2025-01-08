// Интерфейс карты
interface MapService {
  getRoute(start: string, end: string): string;
}

// Реализация Google Maps
class GoogleMapsService {
  findRoute(origin: string, destination: string): string {
    return `Google Maps route from ${origin} to ${destination}`;
  }
}

// Адаптер для Google Maps
class GoogleMapsAdapter implements MapService {
  private googleService: GoogleMapsService;

  constructor() {
    this.googleService = new GoogleMapsService();
  }

  getRoute(start: string, end: string): string {
    return this.googleService.findRoute(start, end);
  }
}

// Пример использования
const mapService: MapService = new GoogleMapsAdapter();
console.log(mapService.getRoute("A", "B"));
