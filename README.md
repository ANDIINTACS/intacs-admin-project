# INTACS Admin Project

## Git Setup and Workflow Instructions

### Initial Setup (One-time)

1. Initialize a Git repository in your project folder (if not already done):
   ```bash
   git init
   ```

2. Add all project files and commit:
   ```bash
   git add .
   git commit -m "Initial commit"
   ```

3. Create a remote repository on a platform like GitHub, GitLab, or Bitbucket.

4. Add the remote repository URL:
   ```bash
   git remote add origin <your-remote-repository-url>
   ```

5. Push your local commits to the remote repository:
   ```bash
   git push -u origin main
   ```

### Cloning the Repository (On your local machine)

Clone the repository once to your local machine:
```bash
git clone <your-remote-repository-url>
```

### Keeping Your Local Copy Updated

To update your local copy with the latest changes from the remote repository, run:
```bash
git pull
```

### Running the Project Locally

1. Navigate to the project folder:
   ```bash
   cd INTACSAdmin
   ```

2. Restore dependencies and build the project:
   ```bash
   dotnet restore
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

4. Open your browser and navigate to:
   ```
   http://localhost:5110
   ```

### Notes

- Ensure you have the .NET SDK installed (version 8.0 or compatible).
- Use Visual Studio or your preferred IDE to open and work on the project.
- Use Git commands to manage your source code and keep it synchronized.

If you need any help with Git commands or project setup, feel free to ask.
