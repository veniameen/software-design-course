class Config {
  private static instance: Config;
  private settings: { [key: string]: string } = {};

  private constructor() {} // Приватный конструктор

  public static getInstance(): Config {
    if (!Config.instance) {
      Config.instance = new Config();
    }
    return Config.instance;
  }

  public set(key: string, value: string): void {
    this.settings[key] = value;
  }

  public get(key: string): string | undefined {
    return this.settings[key];
  }
}

// Пример использования
const config1 = Config.getInstance();
config1.set("apiUrl", "https://api.taxi-system.com");

const config2 = Config.getInstance();
console.log(config2.get("apiUrl"));
