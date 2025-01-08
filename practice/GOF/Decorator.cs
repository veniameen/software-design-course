// Интерфейс заказа
interface Order {
  getDescription(): string;
  getCost(): number;
}

// Базовый заказ
class BasicOrder implements Order {
  getDescription(): string {
    return "Basic taxi order";
  }

  getCost(): number {
    return 100;
  }
}

// Декоратор
class OrderDecorator implements Order {
  protected order: Order;

  constructor(order: Order) {
    this.order = order;
  }

  getDescription(): string {
    return this.order.getDescription();
  }

  getCost(): number {
    return this.order.getCost();
  }
}

// Дополнительные опции
class ChildSeat extends OrderDecorator {
  getDescription(): string {
    return this.order.getDescription() + ", with child seat";
  }

  getCost(): number {
    return this.order.getCost() + 20;
  }
}

class ExtraLuggage extends OrderDecorator {
  getDescription(): string {
    return this.order.getDescription() + ", with extra luggage";
  }

  getCost(): number {
    return this.order.getCost() + 30;
  }
}

// Пример использования
let order: Order = new BasicOrder();
console.log(order.getDescription());
console.log(order.getCost());

order = new ChildSeat(order);
console.log(order.getDescription());
console.log(order.getCost());

order = new ExtraLuggage(order);
console.log(order.getDescription());
console.log(order.getCost());
