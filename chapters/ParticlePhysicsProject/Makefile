# Makefile for ParticlePhysicsProject

# Variables
PROJECT_NAME = ParticlePhysicsProject
SRC_DIR = Source
TESTS_DIR = Tests
OUTPUT_DIR = bin
DATA_DIR = Data

# Targets
.PHONY: all clean test

all: build

# Build the project
build:
	@echo "Building $(PROJECT_NAME)..."
	@mcs -out:$(OUTPUT_DIR)/$(PROJECT_NAME).exe $(SRC_DIR)/Program.cs

# Clean the project
clean:
	@echo "Cleaning..."
	@rm -rf $(OUTPUT_DIR)

# Run unit tests
test:
	@echo "Running unit tests..."
	@mcs -target:library -out:$(TESTS_DIR)/bin/$(PROJECT_NAME).dll $(TESTS_DIR)/*.cs
	@nunit-console $(TESTS_DIR)/bin/$(PROJECT_NAME).dll

# Generate processed data from raw data (example rule)
processed_data: $(DATA_DIR)/RawData/raw_data_file.csv
	@echo "Processing data..."
	# Add commands here to process raw data and generate processed data file
	@echo "Data processing completed."
