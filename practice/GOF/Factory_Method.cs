// Интерфейс пользователя
interface User {
  getRole(): string;
}

// Реализация клиентов, водителей и диспетчеров
class Client implements User {
  getRole(): string {
    return "Client";
  }
}

class Driver implements User {
  getRole(): string {
    return "Driver";
  }
}

class Dispatcher implements User {
  getRole(): string {
    return "Dispatcher";
  }
}

// Фабричный метод для создания пользователей
class UserFactory {
  static createUser(type: string): User {
    switch (type) {
      case "Client":
        return new Client();
      case "Driver":
        return new Driver();
      case "Dispatcher":
        return new Dispatcher();
      default:
        throw new Error("Invalid user type");
    }
  }
}

// Пример использования
const user1 = UserFactory.createUser("Client");
console.log(user1.getRole());

const user2 = UserFactory.createUser("Driver");
console.log(user2.getRole());
