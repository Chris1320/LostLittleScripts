#!/usr/bin/env bash

TMUX_BIN="$(command -v tmux)"

# Sanity check: make sure the detected tmux binary is actually executable
if [[ -z "$TMUX_BIN" || ! -x "$TMUX_BIN" ]]; then
    echo "You need to install \`tmux\` first before using this command."
    exit 1
fi

# Use provided session name if provided
if [[ -n "$1" ]]; then
    SESSION_NAME="$1"
else
    SESSION_NAME="default"
fi

# Use provided path if provided
if [[ -n "$2" ]]; then
    SESSION_PATH="$2"
else
    SESSION_PATH="${PWD}"
fi

# Attempt to attach to existing session or create a new one
${TMUX_BIN} attach -t "$SESSION_NAME" ||
    ${TMUX_BIN} new-session -s "$SESSION_NAME" -c "$SESSION_PATH" ||
    echo "Failed to attach or create tmux session '$SESSION_NAME' on '$SESSION_PATH'." && exit 3
