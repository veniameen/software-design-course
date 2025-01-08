// Интерфейс команды
interface Command {
  execute(): void;
  undo(): void;
}

// Получатель
class Order {
  status: string = "Created";

  setStatus(status: string): void {
    this.status = status;
    console.log(`Order status: ${this.status}`);
  }
}

// Команды
class CreateOrderCommand implements Command {
  constructor(private order: Order) {}

  execute(): void {
    this.order.setStatus("Created");
  }

  undo(): void {
    this.order.setStatus("Cancelled");
  }
}

class CompleteOrderCommand implements Command {
  constructor(private order: Order) {}

  execute(): void {
    this.order.setStatus("Completed");
  }

  undo(): void {
    this.order.setStatus("In Progress");
  }
}

// Инициатор
class OrderManager {
  private commands: Command[] = [];

  executeCommand(command: Command): void {
    this.commands.push(command);
    command.execute();
  }

  undoCommand(): void {
    const command = this.commands.pop();
    if (command) {
      command.undo();
    }
  }
}

// Пример использования
const order = new Order();
const manager = new OrderManager();

const createCommand = new CreateOrderCommand(order);
const completeCommand = new CompleteOrderCommand(order);

manager.executeCommand(createCommand);
manager.executeCommand(completeCommand);

manager.undoCommand();
