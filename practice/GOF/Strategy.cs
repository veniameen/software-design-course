// Интерфейс стратегии
interface PricingStrategy {
  calculatePrice(distance: number): number;
}

// Реализация тарифов
class EconomyStrategy implements PricingStrategy {
  calculatePrice(distance: number): number {
    return distance * 10;
  }
}

class ComfortStrategy implements PricingStrategy {
  calculatePrice(distance: number): number {
    return distance * 15;
  }
}

class BusinessStrategy implements PricingStrategy {
  calculatePrice(distance: number): number {
    return distance * 25;
  }
}

// Контекст
class PriceCalculator {
  private strategy: PricingStrategy;

  constructor(strategy: PricingStrategy) {
    this.strategy = strategy;
  }

  setStrategy(strategy: PricingStrategy): void {
    this.strategy = strategy;
  }

  calculate(distance: number): number {
    return this.strategy.calculatePrice(distance);
  }
}

// Пример использования
const calculator = new PriceCalculator(new EconomyStrategy());
console.log(calculator.calculate(10));

calculator.setStrategy(new ComfortStrategy());
console.log(calculator.calculate(10));

calculator.setStrategy(new BusinessStrategy());
console.log(calculator.calculate(10));