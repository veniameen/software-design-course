// Интерфейс обработчика
interface Handler {
  setNext(handler: Handler): Handler;
  handle(request: string): string | null;
}

// Базовый обработчик
abstract class AbstractHandler implements Handler {
  private nextHandler: Handler | null = null;

  setNext(handler: Handler): Handler {
    this.nextHandler = handler;
    return handler;
  }

  handle(request: string): string | null {
    if (this.nextHandler) {
      return this.nextHandler.handle(request);
    }
    return null;
  }
}

// Конкретные обработчики
class AvailabilityHandler extends AbstractHandler {
  handle(request: string): string | null {
    if (request === "available") {
      return "Driver is available.";
    }
    return super.handle(request);
  }
}

class PaymentHandler extends AbstractHandler {
  handle(request: string): string | null {
    if (request === "paid") {
      return "Payment confirmed.";
    }
    return super.handle(request);
  }
}

class LocationHandler extends AbstractHandler {
  handle(request: string): string | null {
    if (request === "location") {
      return "Location verified.";
    }
    return super.handle(request);
  }
}

// Пример использования
const availability = new AvailabilityHandler();
const payment = new PaymentHandler();
const location = new LocationHandler();

availability.setNext(payment).setNext(location);

console.log(availability.handle("available"));
console.log(availability.handle("paid"));
console.log(availability.handle("location"));
