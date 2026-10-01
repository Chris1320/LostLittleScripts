#!/usr/bin/env bash

TMUX_BIN="$(command -v tmux)"

# Sanity check: make sure the detected tmux binary is actually executable
if [[ -z "$TMUX_BIN" || ! -x "$TMUX_BIN" ]]; then
    echo "You need to install \`tmux\` first before using this command."
    exit 1
fi

if [[ -n "$1" ]]; then
    SESSION_NAME="$1"
else
    SESSION_NAME="default"
fi

# Attempt to attach to existing session or create a new one
${TMUX_BIN} attach -t "$SESSION_NAME" || ${TMUX_BIN} new-session -s "$SESSION_NAME" || echo "Failed to attach or create tmux session '$1'." && exit 3
