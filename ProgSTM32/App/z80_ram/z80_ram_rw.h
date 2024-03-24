// Header: z80 ram io internal header
// File Name: z80_ram_rw_.h
// Author: Mikhail Kaa
// Date: 11.11.2023

#ifndef _Z80_RAM_RW_
#define _Z80_RAM_RW_

#include "z80_ram.h"


// Задержка на NOPах. Привязана к частоте MCU.
#define RAMMDELAY(t) for(uint32_t n = 0; n < (t); n++) asm("NOP")


/* Функции для отладки. */

/// @brief Тест чтения записи памяти.
/// @param  
void z80_ram_test(void);

/// @brief // Тест выводит в консоль первые 512 байт.
/// @param  
void z80_ram_read_test(void);

/// @brief Тест заполняет первые 512 байт памяти значениями равными первым восьми битам адреса.
/// @param  
void z80_ram_write_test(void);

#endif /* _Z80_RAM_RW_ */
