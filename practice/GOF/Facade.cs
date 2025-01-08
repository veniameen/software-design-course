// Подсистемы
class OrderProcessing {
  createOrder(): string {
    return "Order created.";
  }
}

class NotificationService {
  sendNotification(): string {
    return "Notification sent.";
  }
}

class ReportService {
  generateReport(): string {
    return "Report generated.";
  }
}

// Фасад
class OrderFacade {
  private orderProcessing: OrderProcessing;
  private notificationService: NotificationService;
  private reportService: ReportService;

  constructor() {
    this.orderProcessing = new OrderProcessing();
    this.notificationService = new NotificationService();
    this.reportService = new ReportService();
  }

  processOrder(): string {
    let result = "";
    result += this.orderProcessing.createOrder() + " ";
    result += this.notificationService.sendNotification() + " ";
    result += this.reportService.generateReport();
    return result;
  }
}

// Пример использования
const facade = new OrderFacade();
console.log(facade.processOrder());