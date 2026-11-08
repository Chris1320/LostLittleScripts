#!/usr/bin/env bash

FILENAME_RSA="ssh_rsa_key"
FILENAME_ED25519="ssh_ed25519_key"

if [ -n "$1" ]; then
    FILENAME_RSA="${1}-${FILENAME_RSA}"
    FILENAME_ED25519="${1}-${FILENAME_ED25519}"
fi

if [ -f "$FILENAME_RSA" ] || [ -f "${FILENAME_RSA}.pub" ]; then
    echo "File $FILENAME_RSA already exists"
    exit 1
elif [ -f "$FILENAME_ED25519" ] || [ -f "${FILENAME_ED25519}.pub" ]; then
    echo "File $FILENAME_ED25519 already exists"
    exit 1
fi

ssh-keygen -t rsa -b 4096 -f "$FILENAME_RSA" -N ""
ssh-keygen -t ed25519 -f "$FILENAME_ED25519" -N ""
