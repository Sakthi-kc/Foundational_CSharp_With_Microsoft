# Foundational_C#_With_Microsoft

Learning Path: https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/
Pushing to github:
  1. Install git bash
  2. Configure username and mail as every Git commit uses this information
    $ git config --global user.name "John Doe"
    $ git config --global user.email johndoe@example.com
  3. cd /path/to/your/project  //If special characters present, place the path in ""
     Choose git bash in terminal and git init
  4. In VS code,
     + goto Source Terminal icon -> click on + to commit all -> Enter commit message -> Ctrl+Enter
  **or**
     + git add .
     git commit -m "Initial commit"
  5. Login to github, create a repository and copy the HTTPS URL
  6. In VSCode terminal, git remote add origin https://github.com/username/repository.git
  7. Then git push -u origin master - Authenticate github sign-in
  or
  8. To push changes to main branch, beforin git remote type git branch -M main and then git push -u origin main
  9. All the code changes are pushed to master branch
