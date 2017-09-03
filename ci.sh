#!/usr/bin/env bash

# Exit on any error
set -e

# Execute Unit tests
cd ./src/DataGround.Tests
dotnet restore
dotnet xunit