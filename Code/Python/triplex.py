import unidecode
import re

class Triplex:
    """
    Encoding of strings into three-character codes.
    """
    VOWELS = "aeiou"

    def encode_simple(self, source: str) -> str:
        """
        Encodes a source consisting of one component (not divided by '-' or spaces.
        :param source: The source to encode.
        :return: The resulting code.
        """
        if source is None or len(source) == 0:
            raise ValueError("The source string was None or empty")

        source = unidecode.unidecode(source).lower()

        if len(source) < 3:
            return source.upper()

        # assign the first char to result, whether it is a vowel or not
        result = source[0]

        # remove all vowels from source
        source_without_vowels = "".join(c for c in source[1:] if c not in Triplex.VOWELS)

        # try adding chars from source_without_vowels to result
        if len(source_without_vowels) >= 2:
            result += source_without_vowels[0:2]
        else:
            result += source_without_vowels

        if len(result) < 3:
            vowels = "".join(c for c in source[1:] if c in Triplex.VOWELS)

            if len(result) == 2:
                result = result[0] + vowels[0] + result[1]
            else: # length == 1
                result += vowels[0:2]

        return result.upper()

    def encode(self, source: str) -> str:
        """
        Encodes a string consisting of a number of components divided by '-' or  a space character.
        :param source: The source to encode.
        :return: The resulting code.
        """
        components = re.split(r'\s+|-', source)

        if len(components) == 1:
            return self.encode_simple(components[0])

        if len(components) > 3:
            components = components[0:3]

        simple_codes = [self.encode_simple(w) for w in components]

        result = "".join([w[0] for w in simple_codes])

        if len(result) == 2:
            result = result + simple_codes[1][1]

        return result.upper()


if __name__ == '__main__':
    triplex = Triplex()
    source = "Aiioue ueoa"

    result = triplex.encode(source)
    print(result)