# Questionnaire REST API Documentation

This documentation outlines the steps to set up and run a REST API service for a questionnaire application. The service provides a list of questions in JSON format via a GET endpoint `/api/questions`. The application is containerized using Docker and can be easily deployed.

## Table of Contents

1. [Prerequisites](#prerequisites)
2. [Installation](#installation)
3. [Running the Application](#running-the-application)
4. [API Documentation](#api-documentation)
5. [Considerations](#considerations)
6. [Improvements](#improvements)
7. [Assumptions](#assumptions)
8. [Git Repository](#git-repository)

## Prerequisites

Before proceeding, ensure you have the following installed on your system:

- Docker
- Bash (for running the `run.sh` script)

## Installation

1. Clone the repository to your local machine:

```bash
git clone <repository-url>
```

2. Navigate to the project directory:

```bash
cd <project-directory>
```

## Running the Application

1. Execute the `run.sh` script to containerize the application and run it on port 5000:

```bash
bash run.sh
```

This script builds a Docker image for the application and then runs it as a Docker container on port 5000. Once the script execution is complete, the API will be accessible at `http://localhost:5000`.

## API Documentation

### GET /api/questions

Returns a list of questions in JSON format.

**Example Response:**

```json
{
  "questionnaireTitle": "Geography Questions",
  "questionsText": [
    "What is the capital of Cuba?",
    "What is the capital of France?",
    "What is the capital of Poland?",
    "What is the capital of Germany?"
  ]
}
```

## Considerations

- The application uses a hardcoded repository for questions to avoid dependency on real data sources.
- Error handling is implemented for scenarios like invalid routes or server errors.
- The Docker container is configured to run the application on port 5000, but this can be modified if necessary.

## Improvements

- Implement unit tests to ensure the reliability of the codebase.
- Add support for dynamic question generation or integration with an external question database.
- Implement authentication and authorization mechanisms if the API requires restricted access.

## Assumptions

- The focus is on building a simple REST API for serving questionnaire data, so additional features like user authentication are not included.
- The provided questions are static and do not change over time.

## Git Repository

The source code for this project can be found in the following Git repository:

[Repository URL](https://github.com/ddinev90/Questionnaire)

Feel free to explore the codebase and provide feedback or contributions. 

If you encounter any issues or have questions, please don't hesitate to reach out to the project maintainers.
