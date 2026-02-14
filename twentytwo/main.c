#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define MAX_NAMES 6000
#define MAX_LEN 10 //longest name

int compare(const void *a, const void *b) {
    return strcmp((const char *)a, (const char *)b);
}

int main() {
    FILE *fp = fopen("names.txt", "r");
    if (fp == NULL) {
        printf("warning: names.txt file is lose!\n");
        return 1;
    }

    char names[MAX_NAMES][MAX_LEN];
    int count = 0;
    int char_idx = 0;
    int c;
    int in_quotes = 0;

    while ((c = fgetc(fp)) != EOF) {
        if (c == '\"') {
            in_quotes = !in_quotes; 
        } else if (c == ',') {
            
            names[count][char_idx] = '\0';
            count++;
            char_idx = 0;
        } else if (in_quotes) {
            
            names[count][char_idx++] = (char)c;
        }
    }
    names[count][char_idx] = '\0';
    count++;

    fclose(fp);

    qsort(names, count, MAX_LEN, compare);

    long long total_score = 0; 
int i;
    for (i = 0; i < count; i++) {
        int name_value = 0;
        int j;
        for (j = 0; names[i][j] != '\0'; j++) {
            // 'A' char is ASCII 65  value.
            name_value += (names[i][j] - 'A' + 1);
        }
        total_score += (long)(name_value * (i + 1));
    }

    printf("%lld\n", total_score);

    return 0;
}
