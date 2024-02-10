#!/bin/bash

# Change directory to the project directory
cd QuestionnaireApi


# Build Docker image
if [ $? -eq 0 ]; then
docker build -t questionnaire-api -f Dockerfile .
else
  echo "Build failed. Please check Docker build logs."
  read -p "Press any key to exit..." -n1 -s
fi

# Run Docker container
docker run -d -p 5000:5000 questionnaire-api -e ASPNETCORE_URLS="http://+:5000"