## ПО для логистических услуг

Интеграция: REST API

ПО состоит из 3 частей:

1. Первый сервис. Парсить данные(id, auto, speed, distance, rasxodtopliva) из excel файл, вычисляет время (time). По api можно получить эти данные с форматом json.
	1. Язык: Python
	2. Excel file
	3. Modules: PIP, Pandas, FastApi, Uvicorn.
	4. Command to run:  uvicorn fsapi:app --reload
2. Второй сервис. Получает данные через api(post), вычисляет общий расход и возвращает json.
	1. Язык: C#
	2.  WebAPI
3. Клиент. Получает данные с первого сервиса и отправляет к второму сервису с ценой топлива.
	1. ASP.NET MVC
