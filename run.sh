#!/bin/bash

# Change directory to the project directory
cd QuestionnaireApi

# Check if the Docker container exists
container_id=$(docker ps -q -f name=questionnaire-api)

if [ -z "$container_id" ]; then
    echo "No existing container found."
else
    echo "Existing container found. Removing..."
    docker stop $container_id
    docker rm $container_id
fi

# Build Docker image
docker build -t questionnaire-api -f Dockerfile .

# Check if the build was successful
if [ $? -eq 0 ]; then
    # Run Docker container
    docker run -d -p 5000:5000 --name questionnaire-api -e ASPNETCORE_URLS="http://+:5000" questionnaire-api
else
    echo "Build failed. Please check Docker build logs."
    read -p "Press any key to exit..." -n1 -s
fi
