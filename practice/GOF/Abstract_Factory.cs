// Интерфейсы для кнопок и окон
interface Button {
  render(): void;
}

interface Window {
  render(): void;
}

// Реализация для мобильных устройств
class MobileButton implements Button {
  render(): void {
    console.log("Rendering mobile button");
  }
}

class MobileWindow implements Window {
  render(): void {
    console.log("Rendering mobile window");
  }
}

// Реализация для веб-приложений
class WebButton implements Button {
  render(): void {
    console.log("Rendering web button");
  }
}

class WebWindow implements Window {
  render(): void {
    console.log("Rendering web window");
  }
}

// Абстрактная фабрика
interface GUIFactory {
  createButton(): Button;
  createWindow(): Window;
}

// Фабрики для разных платформ
class MobileFactory implements GUIFactory {
  createButton(): Button {
    return new MobileButton();
  }
  createWindow(): Window {
    return new MobileWindow();
  }
}

class WebFactory implements GUIFactory {
  createButton(): Button {
    return new WebButton();
  }
  createWindow(): Window {
    return new WebWindow();
  }
}

// Пример использования
function createUI(factory: GUIFactory): void {
  const button = factory.createButton();
  const window = factory.createWindow();

  button.render();
  window.render();
}

const mobileFactory = new MobileFactory();
createUI(mobileFactory);

const webFactory = new WebFactory();
createUI(webFactory);
