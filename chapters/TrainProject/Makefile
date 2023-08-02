# Makefile for TrainProject

# Specify the main entry point source file
# MAIN_SOURCE = TrainProject/Program.cs
MAIN_SOURCE = TrainProject/Program.cs

# Specify the source files (including folders) for the main project
# MAIN_SOURCES = $(wildcard TrainProject/*.cs)
MAIN_SOURCES = \
    TrainProject/Program.cs \
    TrainProject/Models/Train.cs \
    TrainProject/Services/TrainService.cs


# Specify the compiler and compiler options
CS_COMPILER = mcs
CS_FLAGS = -target:exe -out:TrainProject.exe -langversion:latest

# Build target: Build the main project
build:
	$(CS_COMPILER) $(CS_FLAGS) $(MAIN_SOURCES)

# Run target: Build and run the main project
run: build
	mono TrainProject.exe

# # Test target: Compile and run unit tests (if you have tests)
# test:
# 	# Add commands to run unit tests if applicable


# Test target: Compile and run unit tests
# test: build
# 	$(NUNIT_CONSOLE) $(NUNIT_OPTIONS) TrainProject.Tests.dll


# Clean target: Clean build artifacts
clean:
	rm -f TrainProject.exe

# Set the default target (what runs when you just type 'make' without any target)
.DEFAULT_GOAL := run
