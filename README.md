# Foundational_C-_With_Microsoft

Learning Path: https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/
Pushing to github:
  a. Install git bash
  b. Configure username and mail as every Git commit uses this information
    $ git config --global user.name "John Doe"
    $ git config --global user.email johndoe@example.com
  c. cd /path/to/your/project  //If special characters present, place the path in ""
     git init
  d. In VS code, goto Source Terminal icon -> click on + to commit all -> Enter commit message -> Ctrl+Enter
  or
  d. git add .
     git commit -m "Initial commit"
  e. Login to github, create a repository and copy the HTTPS URL
  f. In VSCode terminal, git remote add origin https://github.com/username/repository.git
  g. Then git push -u origin master - Authenticate github sign-in
  h. All the code changes are pushed to master branch
