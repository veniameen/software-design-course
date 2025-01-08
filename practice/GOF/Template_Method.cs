// Абстрактный класс с шаблонным методом
abstract class OrderProcessor {
  // Шаблонный метод
  processOrder(): void {
    this.selectCar();
    this.calculateCost();
    this.sendNotification();
    this.completeOrder();
  }

  // Шаги алгоритма
  protected abstract selectCar(): void;
  protected abstract calculateCost(): void;

  protected sendNotification(): void {
    console.log("Notification sent to client and driver.");
  }

  protected completeOrder(): void {
    console.log("Order completed successfully.");
  }
}

// Класс для стандартного заказа
class StandardOrder extends OrderProcessor {
  protected selectCar(): void {
    console.log("Standard car selected.");
  }

  protected calculateCost(): void {
    console.log("Cost calculated based on standard rate.");
  }
}

// Класс для заказа с несколькими остановками
class MultiStopOrder extends OrderProcessor {
  protected selectCar(): void {
    console.log("Car for multi-stop trip selected.");
  }

  protected calculateCost(): void {
    console.log("Cost calculated with multiple stops.");
  }
}

// Пример использования
const standardOrder = new StandardOrder();
standardOrder.processOrder();

const multiStopOrder = new MultiStopOrder();
multiStopOrder.processOrder();