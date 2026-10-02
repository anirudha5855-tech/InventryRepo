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
                bat 'dotnet restore Inventy_Demo_MVC_Core.slnx'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build Inventy_Demo_MVC_Core.slnx --configuration Release'
            }
        }
        stage('Test'){
            steps{
                echo 'test project successfully'
            }
        }
        stage('publish'){
            steps{
                bat 'dotnet publish --no-restore --configuration Release --output .\\publish'
            }
        }
        stage('Deploy'){
            steps{
                bat '''
                        if exist 'C:\\inetpub\\wwwroot\\Inventry' rmdir /q /s 'C:\\inetpub\\wwwroot\\Inventry' 
                        mkdir 'C:\\inetpub\\wwwroot\\Inventry'
                    '''
                bat "C:\\Windows\\System32\\xcopy.exe /E /Y /I publish\\* C:\\inetpub\\wwwroot\\Inventry"   

            }
        }
    }
    post {
        success {
            echo "Build, Test, Publish Stages Completed Successfully."
        }
    }

}