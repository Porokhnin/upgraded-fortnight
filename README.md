# Project_template

Это шаблон для решения проектной работы. Структура этого файла повторяет структуру заданий. Заполняйте его по мере работы над решением.

# Задание 1. Анализ и планирование

### 1. Описание функциональности монолитного приложения

**Управление отоплением:**
- Инженер могут производить CRUD операции (установку) для датчиков
- Система поддерживает CRUD операции для датчиков

- Пользователи могут удалённо включать/выключать отопление в своих домах.
- Система поддерживает регулировку температуры датчиков

**Мониторинг температуры:**
- Пользователи могут просматривать температуру для определенной локации
- Система поддерживает получение температуры для определенной локации

- Пользователи могут просматривать температуру для определенного датчика
- Система поддерживает получение температуры для определенного датчика


### 2. Анализ архитектуры монолитного приложения

- Язык программирования: Go
- База данных: PostgreSQL
- Архитектура: Монолитная, все компоненты системы (обработка запросов, бизнес-логика, работа с данными) находятся в рамках одного приложения.
- Взаимодействие: Синхронное, запросы обрабатываются последовательно.


### 3. Определение доменов и границы контекстов

- Управление отоплением
- Мониторинг температуры

### **4. Проблемы монолитного решения**

- Масштабируемость: Ограничена, так как монолит сложно масштабировать по частям.
- Развертывание: Требует остановки всего приложения.


### 5. Визуализация контекста системы — диаграмма С4

![C4 Context AS-IS](docs/warmhouse%20as-is%20context.svg)
![C4 Container AS-IS](docs/warmhouse%20as-is%20container.svg)

# Задание 2. Проектирование микросервисной архитектуры

![C4 Context AS-IS](docs/warmhouse%20to-be%20context.svg)
![C4 Container AS-IS](docs/warmhouse%20to-be%20container.svg)
![C4 Component AS-IS](docs/warmhouse%20to-be%20component.svg)


**Диаграмма кода (Code)**

В задании было сказано про sequance диаграммы, решил отрисовать их.

![register user sequance](https://www.plantuml.com/plantuml/png/fP9FZjCm5CRtFeMLxUZr05KLpI5WZPpO2fRIfZWE4JiwGcmOgKjOyOSJX868Q63IAppVY6U7C25G1iegiVtzFh_l-PsNLXXRhNF6xccRAnxXMspn8tPkvoxSKspSS_hVSpnWZr_S9NwcxnLjNs1Bwtt4c4XjONXqlrGcugBa5VsmBTdgL6_5nlAe5cRziA1zM1U9pXLKEYZJNAkDlKER2QjgyIG0MNrCh2KvQJl8nWMJmef4b6gYVF2JKYRiKQMggM0n2XO-IBamAjEbLKR9G0GvOymVGZmaE3jR_cFRs012dDKdm5aDyLZb2VY8GYmJZx_41Wy4zcx7iSCRzmnxMduTdB3Zs1ynm_Q7sGfa0h34LtFUxV-Alqsqn3T4UrLBtsji_j08KrHRZkzzQhoXumQlXpiPv_EOxx0dnQUWxB0zwZf3VmNTZZO-k1S4-7H-4XQfKS8gIQnK8hNwCQtyTAcDPFHUAvYa--srbzoNJq6cJzaDZV0ttpOAuZ23Fj9hWWyX_9LlrAoooTj0G03kHDYa_15dtwTr1JHuS780twSL35R_ONDEBQtM-JS0)

![auth user sequance](https://www.plantuml.com/plantuml/png/pLRDRiD44BxlKwpIOt5KLCIX2b5FIBrJSK08hN_gM3XnP6yKVbIfJIj0eY9LES2fl49Q6XBr9tc5sJTYTfojDoQ6nkg1bMh7tla-pNxppTI7cHIf77HZncGauu0tu5fTg15CuGMlStK9StY4YVe1Vuyvp3bCu1vt5keCTsR5pX8MyAIkO8RtUvXe2dmUDnWJdanIVfm5AHSP7-2TzKKg8o_gYvxaZQ58kvq4tplTn8tYm3a-QkX8Buw2dloFs538O2Y-9K0uh0gEV6IAP1vc7gg2NU5z7VHyYjM_cI-aS4KMM45V6H9EORxB60lJPD3dEvzt8XbmkAwKYSCJQlGdp57Y2v9qYVjdfDylZ75SMYIddGkmktl0uGRkSV_1WiAa11qJCiSuxN2OuzJFUKKuFCDKZJG98ZSL4UP440wTjZbSJGe3Tzg-InI_OV1IfwdEEHtxad3F1iLXKM4WcAunjXpVTHna_BrCeiPl9YdEXqJ_ulPgqAyQW5gScL1EiZpIwybAnfPZ4DKPFsX9r4XTm7A5woLedZGAEv8UlwUhNWtXUK6MVPQWDni7-2X4qtNTfkTvZG-Ag3GuIOEiynhcxN_i-LwpsRI3Wc_w4KOTwOZzlJtQEAKh-fvIiBpKSiBX5YSWxxQSbGyTnf2oQ8vFQN4Ejt2dvOCxn8-qvbKJv4gTupQQNfTtLXW99XMjOfcjYjDk5OD5v1-8mZ1TMCf8dTCBIkulSlaBUjMgGvv1qfVcOFOcDrdGzKVjZTSAYBY0s1NZEaaqx1mUrk8tT3OA22-KxfCEHSYqv4ApIaszFVhz-vdME_KrhOfMXHiZfs5Raxk0r-zqMlKxtgnIvvjbJu3j9i5M4w5wCbZhj7WgJGfQzIS6qSLPm5idIKzoBucJz9CqyDijjyrB_O75-9_tI1tpaNc-sC4pVxbceLlr4-BlyX6qAEM3X1iERtYe19iK_MZlGtxS4mFPITBeky2tEMYQ6eQSR_NnCSLJp7NRsPySLyno0xFlvM-HhGPpEDGOHFnJmFBmjIUfsQmSf4Iil-YsISTKH-DMDHbfFTI8vnzXixVp5ErHdwVyBxO-KtNJsKfIovNbt6ouRUnMmsXaBlt73l4wwCP_0m00)


# Задание 3. Разработка ER-диаграммы

![ERD](https://img.plantuml.biz/plantuml/png/hLVRJjmm47ttLrYyj8q44gYjgXL2K2W55Q4L2-spIGRYDh4Zsu6kMFuTtv9rl5aIjdspppWpPoxsJ0wb8aBLPO7GEvpJ3B3A0SkAgsQVKf4MOCJaWTCCLuBV5b1A_4XLZWcxBo33gU2F4jy1A2J_K5OHGKfSK0PgNW7cGkKS8M2AgZdUkf4WjZ2HkDOB_8GmJiupFC7VQwr-Vt_wu-10OzlRHd19Ij0Y1N-LsLuGgIBeMqbeuVVlT_U-V33Wb4Zvo4LsHcG-iP9Fktj6CiqvW-Lf0ncT5_oUiYCrmHbHe6W96ZyMe3TPXDvKsGhwlFJjYXTWVHDwCTutHppISrmGMhRAx6v0e_ag59uwOMA_lJQfYE9a1Jz9KQybSiPrbYo9tAm629ZKzX48NVtyqPW-0PaAMYdAMIFmAKes2lm5JubHPgaMVZF0rlhsRtG31YVmG5CNgimkNxU-9bID7pqYPy2aiKSu0q59SLcNjo0c0V5LPBGhnbBWZgsVLrqoOGij7VCCtcXv1anozpf8knn8eMFQbqEdQKsqalyQhgMfWFXmk98uNaaSi6ICyVgsFUFC1y00WLF1IzovPSarZu2P8ggM6gHCXNQlGNS1K6BkKd125B7crIe-AeVhCfByoe6zbPFBo2gd9Jx0gSUxzKNs9khkYz215cqUuiYhSwORhtzPg5iFi0zhefTsPFueLVG1Ugh12LPgOYeC1utnMiy28TSfcPTwRRbMRhrXo_1UZw7V4-Rr36SfC28eTtV5RpRXsCTaPgQfbMBbLGJ55t_CDVTChse_OCW062e7VtHCB3UWTiaLlQD1-sK1i67s-rBSkLgs9ZjZWoxwtv2gUCJvohDvCovgqdRcVEOxEuidErOXEwWj5YrWHo9tpADsy45k_F5GCs1qphasYNppVpRW8kYTg9rAp7aUd_TANFD0llbv9SkEiZIe5VWBri72rnzrMe4tu5yGrBmah-WAyzWruWiAjVSd4fYYH9qADI7dhNk1pnhiQHcehuru3tfUStG8B3D_CIy0)


# Задание 4. Создание и документирование API

### 1. Тип API

Для взаимодействия микросервисов я буду использовать event driven architecture, т.е асинхронное взаимодействие посредством сообщений kafka. Это даст низкую связанность и большую надежность.

### 2. Документация API

Синхронный API сервиса warmhouse.identity представлен в файле Identity Outbound Kafka API. Асинхронный - в Identity Outbound Kafka API


# Задание 5. Работа с docker и docker-compose

Реализован сервис temperature-api и упакован в Docker и добавлен в docker-compose. Порт 8081. Так же добавлен в docker-compose файл настройки для запуска postgres с указанием скрипта инициализации ./smart_home/init.sql


Для проверки можно использовать Postman коллекцию smarthome-api.postman_collection.json и вызвать:

- Create Sensor
- Get All Sensors

Должно при каждом вызове отображаться разное значение температуры


# **Задание 6. Разработка MVP**

Необходимо создать новые микросервисы и обеспечить их интеграции с существующим монолитом для плавного перехода к микросервисной архитектуре. 

### **Что нужно сделать**

1. Создайте новые микросервисы для управления телеметрией и устройствами (с простейшей логикой), которые будут интегрированы с существующим монолитным приложением. Каждый микросервис на своем ООП языке.
2. Обеспечьте взаимодействие между микросервисами и монолитом (при желании с помощью брокера сообщений), чтобы постепенно перенести функциональность из монолита в микросервисы. 

В результате у вас должны быть созданы Dockerfiles и docker-compose для запуска микросервисов. 
