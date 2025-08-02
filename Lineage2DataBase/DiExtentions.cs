namespace Lineage2DataBase.Api
{
    /// <summary>
    /// Предоставляет методы расширения для регистрации сервисов Lineage2DataBase API в контейнере зависимостей.
    /// </summary>
    public static class DiExtensions
    {
        /// <summary>
        /// Добавляет сервисы для Lineage2DataBase API в контейнер зависимостей.
        /// </summary>
        /// <param name="services">Коллекция сервисов для регистрации зависимостей.</param>
        /// <returns>Обновлённая коллекция сервисов.</returns>
        public static IServiceCollection AddLineage2DataBaseApi(this IServiceCollection services)
        {
            // Register your API services here
            // Example: services.AddScoped<IMyService, MyService>();
            return services;
        }
    }
}
