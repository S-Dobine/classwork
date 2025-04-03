#!/bin/bash
if !(git rev-parse --is-inside-work-tree > /dev/null 2>&1;) then
  echo "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"
  echo "* Not inside a Git working directory !"
  echo "* Processing terminating             !"
  echo "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"
  exit
fi
  echo "*************************************"
  echo "* Looks like you in a git directory *"
  echo "* Processing continues              *"
  echo "*************************************"
  git config --global --unset pull.rebase
  git remote remove frankscode
  git remote add frankscode https://github.com/grandcircusco/CSharpAHBC-March-2025-Code.git
<<<<<<< HEAD
<<<<<<< HEAD
  git config --global core.editor "code -w -n"
=======
>>>>>>> 600baf2 (Instructor Push 03/31/2025 11:08:17)
=======
  git config --global core.editor "code -w -n"
>>>>>>> 934d172 (Instructor Push 03/31/2025 14:48:37)
  git config --global merge.tool "merge --no-edit"
  git pull frankscode main --allow-unrelated-histories
  git remote -v
 