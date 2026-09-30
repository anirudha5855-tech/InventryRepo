pipeline {
    agent any
    environment{
      DOTNET_CLI_HOME="C:\\Program Files\\dotnet"
    }


    stages {

        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Restore') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build --configuration Release'
            }
        }
    }
}