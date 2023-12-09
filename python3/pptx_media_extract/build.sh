#!/usr/bin/env bash

./env/bin/python -m nuitka \
    --onefile \
    --enable-plugin=pyside6 \
    --disable-console \
    ./pptx_media_extract.py
