#!/usr/bin/env zsh

echo "Installing essentials..."
pip install --upgrade pip wheel build setuptools twine
echo "Installing frequently used..."
pip install --upgrade flake8 requests tqdm youtube-dl pytest
echo "Done."
exit 0
