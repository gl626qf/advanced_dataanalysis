# Makefile for DataAnalysisProject

# Specify the main entry point source file
MAIN_SOURCE = DataAnalysisProject/Source/Program.cs

# Specify the source files (including folders) for the main project
# MAIN_SOURCES = DataAnalysisProject/Source/Program.cs \
#     DataAnalysisProject/Source/Analysis/DataAnalyzer.cs \
#     DataAnalysisProject/Source/DataAccess/DataLoader.cs \


MAIN_SOURCES =  DataAnalysisProject/Source/Program.cs\
				$(wildcard DataAnalysisProject/Source/Analysis/*.cs) \
				$(wildcard DataAnalysisProject/Source/DataAccess/*.cs) \
				$(wildcard DataAnalysisProject/Source/Models/*.cs)


# Specify the source files (including folders) for the test project
# TEST_SOURCES = $(wildcard Tests/UnitTests/*.cs)

# Specify the compiler and compiler options
CS_COMPILER = mcs
CS_FLAGS = -target:exe -out:DataAnalysisProject.exe -langversion:latest

# Build target: Build the main project
build:
	$(CS_COMPILER) $(CS_FLAGS) $(MAIN_SOURCES)

# Test target: Compile and run unit tests
# test:
# 	$(CS_COMPILER) $(CS_FLAGS) $(MAIN_SOURCES) $(TEST_SOURCES)
# 	mono DataAnalysisProject.exe

# Clean target: Clean build artifacts
clean:
	rm -f DataAnalysisProject.exe

# Additional targets (optional): Add any other targets you need for your project
# For example, you can add targets for running the application, packing NuGet packages, etc.
run:
	mono DataAnalysisProject.exe

# pack:
# 	# Add packing commands for your project if needed

# Set the default target (what runs when you just type 'make' without any target)
.DEFAULT_GOAL := build
