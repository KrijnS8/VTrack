SHELL := /bin/bash

# =============================================================================
# Configuration
# =============================================================================

SOLUTION := RideConnect.sln

API_PROJECT := apps/api/RideConnect.API
INFRA_PROJECT := apps/api/RideConnect.Infrastructure

DOCKER_COMPOSE := infrastructure/docker/compose.dev.yml

# =============================================================================
# .NET
# =============================================================================

.PHONY: restore build clean run watch

restore:
	dotnet restore $(SOLUTION)

build:
	dotnet build $(SOLUTION)

clean:
	dotnet clean $(SOLUTION)
	find . -type d \( -name bin -o -name obj \) -exec rm -rf {} +

run:
	dotnet run --project $(API_PROJECT)

watch:
	dotnet watch --project $(API_PROJECT)

# =============================================================================
# Entity Framework
# =============================================================================

.PHONY: migration update remove list

migration:
ifndef name
	$(error Usage: make migration name=MigrationName)
endif
	dotnet ef migrations add $(name) \
		--project $(INFRA_PROJECT) \
		--startup-project $(API_PROJECT)

update:
	dotnet ef database update \
		--project $(INFRA_PROJECT) \
		--startup-project $(API_PROJECT)

remove:
	dotnet ef migrations remove \
		--project $(INFRA_PROJECT) \
		--startup-project $(API_PROJECT)

list:
	dotnet ef migrations list \
		--project $(INFRA_PROJECT) \
		--startup-project $(API_PROJECT)

# =============================================================================
# Docker
# =============================================================================

.PHONY: up down restart logs ps

up:
	docker compose -f $(DOCKER_COMPOSE) up -d

down:
	docker compose -f $(DOCKER_COMPOSE) down

restart:
	docker compose -f $(DOCKER_COMPOSE) down
	docker compose -f $(DOCKER_COMPOSE) up -d

logs:
	docker compose -f $(DOCKER_COMPOSE) logs -f

ps:
	docker compose -f $(DOCKER_COMPOSE) ps

# =============================================================================
# PostgreSQL
# =============================================================================

.PHONY: psql

psql:
	docker exec -it rideconnect-postgres \
		psql -U postgres -d rideconnect